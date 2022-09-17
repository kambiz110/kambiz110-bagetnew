using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Dto
{
    public class GetCommentForAdminDto
    {
        public PagerDto PagerDto { get; set; }
        public List<CommentViewModelDto> comments { get; set; }
    }
}
