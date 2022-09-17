using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Dto
{
    public class ResetPasswordDto
    {
        [Display(Name = "نام کاربری")]
        public string FullName { get; set; }

        public string Id { get; set; }

        [Display(Name = "رمز عبور جدید")]
        [Required(ErrorMessage = " {0}  را وارد نمائید ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "تکرار پسورد را وارد نمایید")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "پسورد و تکرار آن باید برابر باشد")]
        [Display(Name = "تکرار پسورد")]
        public string RePassword { get; set; }
    }
}
