using Application.Users.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Dto
{
    public class AddTicketDto
    {
        public string UserId { get; set; }
        [Display(Name = "عنوان ")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = " پیغام")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Comment { get; set; }
        [MobliPhon]
        [Display(Name = " شماره تلفن")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string PhoneNumber { get; set; }
        public string Ip { get; set; }

    }
}
