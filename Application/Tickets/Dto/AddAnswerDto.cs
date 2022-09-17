using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tickets.Dto
{
   public class AddAnswerDto
    {
        public long Id { get; set; }
        public string AnswerUserId { get; set; }
        [Display(Name = "عنوان ")]
        public string Title { get; set; }
        [Display(Name = " پیغام")]
        public string Comment { get; set; }

        [Display(Name = "جواب")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Answer { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
    }
}
