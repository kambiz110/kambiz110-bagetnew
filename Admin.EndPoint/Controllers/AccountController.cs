using Admin.EndPoint.Helper;
using Application.Users.Dto;
using Application.Users.Token;
using Domain.Users;
using Infrastructure.SMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Admin.EndPoint.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IGeneritTokenUser tokenUser;
        private readonly ISmsServices smsServices;

        public AccountController(UserManager<User> userManager, 
            SignInManager<User> signInManager ,
            IGeneritTokenUser tokenUser ,
            ISmsServices smsServices
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.tokenUser = tokenUser;
            this.smsServices = smsServices;
        }

        public IActionResult Login(string returnUrl = "/")
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl,
            });
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));

                String messages2 = String.Join(Environment.NewLine, ModelState.Values.SelectMany(v => v.Errors)
                                                           .Select(v => v.ErrorMessage + " " + v.Exception));
                return View(model);
            }
            var user = _userManager.FindByNameAsync(model.Email).Result;
            if (user == null)
            {

                ModelState.AddModelError("", "کاربر یافت نشد");
                return View(model);
            }
            _signInManager.SignOutAsync();
            var result = _signInManager.PasswordSignInAsync(user, model.Password
                , model.IsPersistent, true).Result;
            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "حساب کاربری شما غیر فعال گردیده است شما می توانید بعد از 20 دقیقه مجددا وارد شوید!!!");
                return View();
            }
            if (result.Succeeded)
            {
               // SmsServices sendSms = new SmsServices();
               // sendSms.verificationCodeWithPatern(user.FullName,"09055510734");
              //  sendSms.singleUserSendSMS("ورود به حساب کاربری ادمین موفق !",new string[] { "09055510734" });
                var addClaimes = _userManager.AddClaimAsync(user, new Claim("FullName", user.FullName)).Result;
                var token = tokenUser.creatToken(user.Id);
                string redirect;
                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                {
                    redirect = model.ReturnUrl;
                }
                else
                {
                    redirect = Url.Content("~/")!;
                }
               // return RedirectToAction("Index", "CategoreItems" ,new { area = ""});
              return Redirect(redirect);
            }

            ModelState.AddModelError(string.Empty, "نام کاربری و یا رمز عبور را به درستی وارد نمائید !!!");

            return View(model);
        }

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccessDenied(string message)
        {
            if (!String.IsNullOrEmpty(message))
            {
                ViewBag.message = message;
            }
            return View();
        }
        public JsonResult testsms()
        {
          
            smsServices.verificationCodeWithPatern("الهام حیدری عزیزم", "09924044207");
            //smsServices.singleUserSendSMS("ورود به حساب کاربری ادمین موفق !",new string[] { "09055510734" });
            return Json("test sms");
        }
    }
}
