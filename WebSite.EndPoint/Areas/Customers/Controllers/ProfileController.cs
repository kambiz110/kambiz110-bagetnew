using Application.Users.Dto;
using DNTCaptcha.Core;
using Domain.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Areas.Customers.Controllers
{
    [Area("Customers")]
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public ProfileController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [ValidateDNTCaptcha(
            ErrorMessage = "عبارت امنیتی را به درستی وارد نمائید",
            CaptchaGeneratorLanguage = Language.Persian,
            CaptchaGeneratorDisplayMode = DisplayMode.NumberToWord)]
        [HttpPost]
        public IActionResult ChangePassword(ResetPasswordCustomerDto dto)
        {
            if (!ModelState.IsValid)
            {
                var query = from state in ModelState.Values
                            from error in state.Errors
                            select error.ErrorMessage;

                var errorList = query.ToList();
                ViewBag.Errors = errorList;

                return View();
            }
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            _signInManager.SignOutAsync();
            var result = _signInManager.PasswordSignInAsync(user, dto.OldPassword, false, true).Result;
            if (result.Succeeded == true)
            {
                var result2 = _userManager.RemovePasswordAsync(user).Result;
                if (result2.Succeeded != true)
                {

                    var result3 = _userManager.AddPasswordAsync(user, dto.Password).Result;
                }
            }


            return RedirectToAction("Index","Home" ,new { area=""});
        }
    }
}
