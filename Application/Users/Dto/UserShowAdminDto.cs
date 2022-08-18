using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Dto
{
  public  class UserShowAdminDto
    {
        public string Id { get; set; }
        [Display(Name = "نام")]
        public string FullName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [Display(Name = "تلفن")]
        public string PhoneNumber { get; set; }
    }
}
