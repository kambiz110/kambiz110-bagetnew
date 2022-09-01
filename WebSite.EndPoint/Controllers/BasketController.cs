using Application.BasketsService;
using Application.Discounts;
using Application.Orders;
using Application.Payments;
using Application.Users;
using Domain.Order;
using Domain.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private string userId = null;
        public BasketController(IBasketService basketService
            , SignInManager<User> signInManager
            , IUserAddressService userAddressService
            , IOrderService orderService
            , IPaymentService payment
            ,IDiscountService discountService
            ,UserManager<User> userManager)
        {
            this.basketService = basketService;
            this.signInManager = signInManager;
            this.userAddressService = userAddressService;
            this.orderService = orderService;
            this.paymentService = payment;
            this.discountService = discountService;
            this.userManager = userManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
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
        [HttpPost]
        public IActionResult Index(int CatalogitemId, int quantity = 1)
        {
            var basket = GetOrSetBasket();
            //افزودن محصول به سبد خرید
            basketService.AddItemToBasket(basket.Id, CatalogitemId, quantity);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// حذف محصول از سبد خرید
        /// </summary>
        /// <param name="ItemId"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RemoveItemFromBasket(int ItemId)
        {
            basketService.RemoveItemFromBasket(ItemId);
            return RedirectToAction(nameof(Index));
        }
        /// <summary>
        /// تعیین تعداد محصول یک آیتم در سبد خرید
        /// </summary>
        /// <param name="basketItemId"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult setQuantity(int basketItemId, int quantity)
        {
            return Json(basketService.SetQuantities(basketItemId, quantity));
        
        }


        /// <summary>
        /// نمایش محتویات سبد برای تعیین آدرس و نحوه پرداخت
        /// </summary>
        /// <returns></returns>
        public IActionResult ShippingPayment()
        {
            ShippingPaymentViewModel model = new ShippingPaymentViewModel();
            string userId = ClaimUtility.GetUserId(User);
            model.Basket = basketService.GetBasketForUser(userId);
            model.UserAddresses = userAddressService.GetAddress(userId);
            if (model==null || model.Basket==null || model.Basket.Items.Count()<1)
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
        public IActionResult ShippingPayment(int Address, PaymentMethod PaymentMethod)
        {
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
            string userId = ClaimUtility.GetUserId(User);
            var paymentId = TempData["paymentId"];
            var model = paymentService.GetPaymentWithOrderForCheckoutPage(paymentId.ToString(), userId);
            return View(model);
        }



        [AllowAnonymous]
        [HttpPost]
        //اعمال تخفیف روی سبد خرید
        public IActionResult ApplyDiscount(string CouponCode,int BasketId)
        {
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
            discountService.RemoveDiscountFromBasket(id);
            return RedirectToAction(nameof(Index));
        }


        /// <summary>
        /// بدست آوردن و یا ایجاد سبد خرید
        /// </summary>
        /// <returns></returns>
        private BasketDto GetOrSetBasket()
        {
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
