using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Dto
{
    public class AddCommentDto
    {
        [Display(Name = " نام کاربر ")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Name { get; set; }
        public string Image { get; set; } = "/users/default-user.png";
        public long? ParentId { get; set; }
        [Display(Name = " پیغام ")]
        [Required(ErrorMessage = "{0} را وارد نمایید")]
        public string Message { get; set; }
        public int PostId { get; set; }
        public string UserId { get; set; } 
        public string IP { get; set; }

    }
}
