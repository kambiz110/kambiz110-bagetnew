﻿using Application.BasketsService;
using Application.Dtos;
using Application.Users.Command;
using Application.Users.Token;
using Domain.Users;
using Infrastructure.SMS;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebSite.EndPoint.Models.ViewModels.Register;
using WebSite.EndPoint.Models.ViewModels.User;
using WebSite.EndPoint.Utilities.Filters;

namespace WebSite.EndPoint.Controllers
{
    //  [ServiceFilter(typeof(SaveVisitorFilter))]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IBasketService basketService;
        private readonly ILoginWithSmsCodeServices loginWithSmsCode;
        private readonly ISmsServices smsServices;
        private readonly IGeneritTokenUser tokenUser;
        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager, IBasketService basketService
            , ILoginWithSmsCodeServices loginWithSmsCode
            , ISmsServices smsServices, IGeneritTokenUser tokenUser)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.basketService = basketService;
            this.loginWithSmsCode = loginWithSmsCode;
            this.smsServices = smsServices;
            this.tokenUser = tokenUser;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var query = from state in ModelState.Values
                            from error in state.Errors
                            select error.ErrorMessage;

                var errorList = query.ToList();
                errorList.Remove("The value '' is invalid.");
                ViewBag.Errors = errorList;
                return View(model);
            }
            User newUser = new User()
            {
                Email = model.Email,
                UserName = model.Email,
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber,
            };

            var result = _userManager.CreateAsync(newUser, model.Password).Result;
            if (result.Succeeded)
            {

                var user = _userManager.FindByNameAsync(newUser.Email).Result;
                TransferBasketForuser(user.Id);
                _signInManager.SignInAsync(user, true).Wait();
                return RedirectToAction(nameof(Profile));
            }
            var query2 = result.Errors.Select(p => p.Description).ToList();



            var errorList2 = query2;

            ViewBag.Errors = errorList2;


            return View(model);
        }

        public IActionResult Profile()
        {
            return View();
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
                var addClaimes = _userManager.AddClaimAsync(user, new Claim("FullName", user.FullName)).Result;
                TransferBasketForuser(user.Id);
                return Redirect(model?.ReturnUrl ?? "/");
            }
            if (result.RequiresTwoFactor)
            {
                //
            }
            ModelState.AddModelError(string.Empty, "نام کاربری و یا رمز عبور را به درستی وارد نمائید !!!");

            return View(model);
        }

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private void TransferBasketForuser(string userId)
        {
            string cookieName = "BasketId";
            if (Request.Cookies.ContainsKey(cookieName))
            {
                var anonymousId = Request.Cookies[cookieName];
                basketService.TransferBasket(anonymousId, userId);
                Response.Cookies.Delete(cookieName);
            }
        }

        [HttpGet]
        public IActionResult LoginViaSms()
        {
            ViewBag.error = "";
            return View();
        }
        /// <summary>
        /// دریافت شماره تلفن همراه و ارسال پیامک تایید
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> LoginViaSms(string PhoneNumber)
        {
            if (String.IsNullOrEmpty(PhoneNumber))
            {
                ViewBag.Errors = "شماره تلفن را وارد  ننموده اید!!!";
                return View();
            }
            var IsUser = loginWithSmsCode.FindUserWithPhonenumber(PhoneNumber);
            if (IsUser.IsSuccess)
            {
                var smsCode = loginWithSmsCode.GetCode(PhoneNumber);
                //smsCode پیامک کنید به همین شماره
                await smsServices.verificationCodeWithPatern(IsUser.Data.FullName, PhoneNumber, smsCode);
                var token = tokenUser.creatToken(IsUser.Data.Id);
                TempData["token"] = token.Data;
                TempData["tokencreator"] = IsUser.Data.Id;
                return RedirectToAction("ConfirmPhoneNumber", "Account", new { PhoneNumber = PhoneNumber });
            }
            ViewBag.Errors = "شماره تلفن نامعتبر است و یا  شما ثبت نام ننموده اید!!!";
            return View();
        }

        [HttpGet]
        public IActionResult ConfirmPhoneNumber(string PhoneNumber)
        {

            string token = TempData["token"].ToString();
            ViewBag.tokencreator = TempData["tokencreator"].ToString();
            ViewBag.token = token;
            ViewBag.PhoneNumber = PhoneNumber;
            return View();
        }
        /// <summary>
        /// تایید شماره موبایل و کد دریافتی کاربر
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <param name="SmsCode"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> ConfirmPhoneNumber(string PhoneNumber, string SmsCode, string token, string tokencreator)
        {

            await _signInManager.SignOutAsync();
            var loginResult = loginWithSmsCode.LoginWithSmsCode(PhoneNumber, SmsCode, token, tokencreator);
            if (loginResult.IsSuccess == false)
            {
                return RedirectToAction("LoginViaSms", "Account");


            }
            var user =  _userManager.FindByIdAsync(loginResult.Data.Id).Result;
            var addClaimes = _userManager.AddClaimAsync(user, new Claim("FullName", loginResult.Data.FullName)).Result;
            await _signInManager.SignInAsync(loginResult.Data, true);
            TransferBasketForuser(loginResult.Data.Id);
            return RedirectToAction("Index", "Home");

        }

    }
}
