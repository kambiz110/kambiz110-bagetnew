using Application.Payments;
using DotNet.RateLimiter.ActionFilters;
using Dto.Payment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Utilities;
using ZarinPal.Class;
namespace WebSite.EndPoint.Controllers
{
    public class PayController : Controller
    {
        /// <summary>
        /// کلاس های مربوط به زرین پال
        /// </summary>
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        //****************************************

        private readonly IConfiguration configuration;
        private readonly IPaymentService paymentService;
        private readonly string merchendId;
        private readonly ILogger<PayController> _logger;
        private static readonly NLog.Logger nlog = NLog.LogManager.GetCurrentClassLogger();
        public PayController(IConfiguration configuration, IPaymentService paymentService, ILogger<PayController> logger)
        {
            this.configuration = configuration;
            this.paymentService = paymentService;
            merchendId = configuration["ZarinpalMerchendId"];

            ///سازنده های مربوط به زرین پال
            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
            _logger = logger;
        }

        [RateLimit(PeriodInSec = 5, Limit = 5)]
        public async Task<IActionResult> Index(Guid PaymentId)
        {
            nlog.Trace("Trace");
            var payment = paymentService.GetPayment(PaymentId);
            if (payment == null)
            {
                return NotFound();
            }
            string userId = ClaimUtility.GetUserId(User);
            if (userId != payment.Userid)
            {
                return BadRequest();
            }
            string callbackUrl = Url.Action(nameof(Verify), "pay", new { payment.Id }, protocol: Request.Scheme);
            //برای تست خطوط زیر کامنت شده است
            var resultZarinpalRequest = await _payment.Request(new DtoRequest()
            {
                Amount = payment.Amount,
                CallbackUrl = callbackUrl,
                Description = payment.Description,
                Email = payment.Email,
                MerchantId = merchendId,
                Mobile = payment.PhoneNumber,
            }, Payment.Mode.zarinpal
                );
            //  return RedirectToAction("Verify", "pay", new { Id= payment.Id, Authority = "test_Authority" });
            return Redirect($"https://zarinpal.com/pg/StartPay/{resultZarinpalRequest.Authority}");
        }

        [RateLimit(PeriodInSec = 5, Limit = 5)]
        public IActionResult Verify(Guid Id, string Authority /*,string PaymentId*/)
        {
            nlog.Trace("Trace");
            string Status = HttpContext.Request.Query["Status"];

            if (Status != "" && Status != null && Status.ToString().ToLower() == "ok" && Authority != "")
            {
                var payment = paymentService.GetPayment(Id);
               // TempData["TempDatapaymentId"] = Id.ToString();
                HttpContext.Session.SetString("paymentId", Id.ToString());
                if (payment == null)
                {
                    return RedirectToAction("Display" , "Home");
                }


                //برای چک کردن جعلی نبودن پرداخت
                var client = new RestClient("https://www.zarinpal.com/pg/rest/WebGate/PaymentVerification.json");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", $"{{\"MerchantID\" :\"{merchendId}\",\"Authority\":\"{Authority}\",\"Amount\":\"{payment.Amount}\"}}", ParameterType.RequestBody);
                var response = client.Execute(request);

                VerificationPayResultDto verification =
                  JsonConvert.DeserializeObject<VerificationPayResultDto>(response.Content);

                if (verification.Status == 100)
                {
                    bool verifyResult = paymentService.VerifyPayment(Id, Authority, verification.RefID);
                    if (verifyResult)
                    {

                        return RedirectToAction("Index", "Orders", new { area = "Customers" });
                    }
                    else
                    {
                        TempData["message"] = "پرداخت انجام شد اما ثبت نشد";
                        return RedirectToAction("checkout", "basket", new { payResult = false });
                    }
                }
                else
                {
                    return RedirectToAction("checkout", "basket", new { payResult = false });
                }

            }
         

            return RedirectToAction("checkout", "basket", new { payResult = false });
        }

        [RateLimit(PeriodInSec = 5, Limit = 5)]
        [HttpGet]
        [Route("pay/CancelPay/{PaymentId}")]
        public async Task<IActionResult> CancelPay(Guid PaymentId)
        {
            nlog.Trace("Trace");
            await paymentService.CanselPayment(PaymentId);
            return Redirect("/customers/orders/index");
        }
    }


    public class VerificationPayResultDto
    {
        public int Status { get; set; }
        public long RefID { get; set; }
    }
}
