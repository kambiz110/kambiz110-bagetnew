using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Models.Validator;

namespace WebSite.EndPoint.Models.ViewModels.Register
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "نام و نام خانوادگی را وارد نمایید")]
        [Display(Name = "نام و نام خانوادگی")]
        [MaxLength(100, ErrorMessage = "نام و نام خانوادگی نباید بیش از 100 کاراکتر باشد")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ایمیل را وارد نمایید")]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }


        [Required(ErrorMessage = "پسورد را وارد نمایید")]
        [DataType(DataType.Password)]
        [Display(Name = "پسورد")]
        public string Password { get; set; }

        [Required(ErrorMessage = "تکرار پسورد را وارد نمایید")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "پسورد و تکرار آن باید برابر باشد")]
        [Display(Name = "تکرار پسورد")]
        public string RePassword { get; set; }
        [MobliPhon]
        [Display(Name = "شماره موبایل ")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string PhoneNumber { get; set; }
    }
}
