using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Dto
{
    public class GetRoleDto
    {
        public string Id { get; set; }
        [Display(Name = "عنوان نقش")]
        public string Name { get; set; }

        public string userName { get; set; }
    }
}
