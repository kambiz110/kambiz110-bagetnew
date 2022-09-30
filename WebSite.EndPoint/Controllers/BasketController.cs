using Application.BasketsService;
using Application.Discounts;
using Application.Orders;
using Application.Payments;
using Application.Users;
using Domain.Order;
using Domain.Users;
using DotNet.RateLimiter.ActionFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Models.ViewModels.Baskets;
using WebSite.EndPoint.Utilities;

namespace WebSite.EndPoint.Controllers
{
    [Authorize]
    public class BasketController : Controller
    {
        private readonly IBasketService basketService;
        private readonly SignInManager<User> signInManager;
        private readonly IUserAddressService userAddressService;
        private readonly IOrderService orderService;
        private readonly IPaymentService paymentService;
        private readonly IDiscountService discountService;
        private readonly UserManager<User> userManager;
        private readonly ILogger<BasketController> _logger;
        private static readonly NLog.Logger nlog = NLog.LogManager.GetCurrentClassLogger();
        private string userId = null;
        public BasketController(IBasketService basketService
            , SignInManager<User> signInManager
            , IUserAddressService userAddressService
            , IOrderService orderService
            , IPaymentService payment
            , IDiscountService discountService
            , UserManager<User> userManager, ILogger<BasketController> logger)
        {
            this.basketService = basketService;
            this.signInManager = signInManager;
            this.userAddressService = userAddressService;
            this.orderService = orderService;
            this.paymentService = payment;
            this.discountService = discountService;
            this.userManager = userManager;
            _logger = logger;
        }
        [RateLimit(PeriodInSec = 5, Limit = 10)]
        [AllowAnonymous]
        public IActionResult Index()
        {
            nlog.Trace("Trace");
            var data = GetOrSetBasket();
            return View(data);
        }

        /// <summary>
        /// افزودن محصول به سبد خرید
        /// </summary>
        /// <param name="CatalogitemId"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [RateLimit(PeriodInSec = 5, Limit = 10)]
        [HttpPost]
        public IActionResult Index(int CatalogitemId, int quantity = 1)
        {
            nlog.Trace("Trace");
            var basket = GetOrSetBasket();
            //افزودن محصول به سبد خرید
            basketService.AddItemToBasket(basket.Id, CatalogitemId, quantity);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// حذف محصول از صفحه سبد خرید
        /// </summary>
        /// <param name="ItemId"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RemoveItemFromBasket(int ItemId)
        {
            nlog.Trace("Trace");
            basketService.RemoveItemFromBasket(ItemId);

            return Json(true);
        }
        /// <summary>
        /// حذف محصول از  هدر سایت سبد خرید
        /// </summary>
        /// <param name="ItemId"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [RateLimit(PeriodInSec = 5, Limit = 10)]
        [HttpPost]
        public IActionResult RemoveItemFromHeaderBasket(int ItemId)
        {
            nlog.Trace("Trace");
            basketService.RemoveItemFromBasket(ItemId);
            return Redirect(Request.Headers["Referer"].ToString());
            //  return Json(true);
        }
        /// <summary>
        /// تعیین تعداد محصول یک آیتم در سبد خرید
        /// </summary>
        /// <param name="basketItemId"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [RateLimit(PeriodInSec = 10, Limit = 20)]
        [HttpPost]
        public IActionResult setQuantity(int basketItemId, int quantity)
        {
            nlog.Trace("Trace");
            return Json(basketService.SetQuantities(basketItemId, quantity));

        }


        /// <summary>
        /// نمایش محتویات سبد برای تعیین آدرس و نحوه پرداخت
        /// </summary>
        /// <returns></returns>
        public IActionResult ShippingPayment()
        {
            nlog.Trace("Trace");
            ShippingPaymentViewModel model = new ShippingPaymentViewModel();
            string userId = ClaimUtility.GetUserId(User);
            model.Basket = basketService.GetBasketForUser(userId);
            model.UserAddresses = userAddressService.GetAddress(userId);
            if (model == null || model.Basket == null || model.Basket.Items.Count() < 1)
            {
                return Redirect("~/");
            }
            return View(model);
        }
        /// <summary>
        /// تعیین آدرس و نحوه پرداخت و انتقال به درگاه خرید
        /// ایجاد سفارش و انتقال سبد خرید به آن
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="PaymentMethod"></param>
        /// <returns></returns>
        [HttpPost]
        [RateLimit(PeriodInSec = 5, Limit = 5)]
        public IActionResult ShippingPayment(int Address, PaymentMethod PaymentMethod)
        {
            nlog.Trace("Trace");
            //قرار دان پیش فرض نحوه پرداخت روی آنلاین
            PaymentMethod = PaymentMethod.OnlinePaymnt;
            string userId = ClaimUtility.GetUserId(User);
            var basket = basketService.GetBasketForUser(userId);
            //ایجاد سفارش بر اساس سبد خرید کاربر
            int orderId = orderService.CreateOrder(basket.Id, Address, PaymentMethod);
            if (PaymentMethod == PaymentMethod.OnlinePaymnt)
            {
                //ثبت پرداخت با ایجاد شناسه خرید بر اساس سفارش
                var payment = paymentService.PayForOrder(orderId);
                //ارسال به درگاه پرداخت
                return RedirectToAction("Index", "Pay", new { PaymentId = payment.PaymentId });
            }
            else
            {
                //برو به صفحه سفارشات من
                return RedirectToAction("Index", "Orders", new { area = "customers" });
            }
        }

        public IActionResult Checkout(bool payResult)
        {
            nlog.Trace("Trace");
            if (!payResult)
            {
                string userId = ClaimUtility.GetUserId(User);
             
                var paymentId = HttpContext.Session.GetString("paymentId");
                if (paymentId == null)
                {
                    ViewBag.error = "خطا در دریافت اطلاعات ";
                    return View(null);
                }
          
                else
                {
                    HttpContext.Session.SetString("paymentId", "");
                }
                var model = paymentService.GetPaymentWithOrderForCheckoutPage(paymentId, userId);

                if (model == null)
                {
                    ViewBag.error = "خطا در ارسال اطلاعات ";
                    return View(null);
                }
                ViewBag.error = "پرداخت شما نا موفق بود!!! ";
                return View(model);
            }


            return RedirectToAction("Index", "Orders", new { area = "Customers" });
        }

        //اعمال تخفیف روی سبد خرید
        [HttpPost]
        public IActionResult ApplyDiscount(string CouponCode, int BasketId)
        {
            nlog.Trace("Trace");
            var user = userManager.GetUserAsync(User).Result;
            var valisDiscount = discountService.IsDiscountValid(CouponCode, user);


            if (valisDiscount.IsSuccess)
            {
                discountService.ApplyDiscountInBasket(CouponCode, BasketId);
            }
            else
            {
                TempData["InvalidMessage"] = String.Join(Environment.NewLine, valisDiscount.Message.Select(a => String.Join(", ", a)));

            }

            return RedirectToAction(nameof(Index));
        }


        [AllowAnonymous]
        //حذف تخفیف از سبد خرید
        public IActionResult RemoveDiscount(int id)
        {
            nlog.Trace("Trace");
            discountService.RemoveDiscountFromBasket(id);
            return RedirectToAction(nameof(Index));
        }


        /// <summary>
        /// بدست آوردن و یا ایجاد سبد خرید
        /// </summary>
        /// <returns></returns>
        private BasketDto GetOrSetBasket()
        {
            nlog.Trace("Trace");
            if (signInManager.IsSignedIn(User))
            {
                userId = ClaimUtility.GetUserId(User);
                return basketService.GetOrCreateBasketForUser(userId);
            }
            else
            {
                SetCookiesForBasket();
                return basketService.GetOrCreateBasketForUser(userId);
            }
        }

        private void SetCookiesForBasket()
        {
            string basketCookieName = "BasketId";
            if (Request.Cookies.ContainsKey(basketCookieName))
            {
                userId = Request.Cookies[basketCookieName];
            }
            if (userId != null) return;
            userId = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions { IsEssential = true };
            cookieOptions.Expires = DateTime.Today.AddYears(2);
            Response.Cookies.Append(basketCookieName, userId, cookieOptions);


        }
    }
}
