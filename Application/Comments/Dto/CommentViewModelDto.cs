using Domain.Catalogs;
using Domain.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Dto
{
    public class CommentViewModelDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; } = "users/default-user.png";
        public long? commentId { get; set; }
        public long? ParentId { get; set; }
        public string ParentTitle { get; set; }
        public string Message { get; set; }
        public int PostId { get; set; }
        public CatalogItem Post { get; set; }
        public Comment comment { get; set; }
        [Display(Name = "وضعیت")]
        public byte Status { get; set; } = 0;
        public DateTime CommentDate { get; set; }
    }
}
