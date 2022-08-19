using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Dto
{
    public class RolesInUserDto
    {
        [Display(Name = "نام و نام خانوادگی")]

        public string FullName { get; set; }
        public string UserId { get; set; }
        [Display(Name = "نقش کاربری")]
        public GetShortRolesForShowAdmin getShortRoles { get; set; }

    }
}
