using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Dto
{
    public class AjaxAnswerCommentDto
    {
        // Answer: answer, Postid=postID, Commentid= commentID
        public int Postid { get; set; }
        public int Commentid { get; set; }
        public string Answer { get; set; }
        public string userName { get; set; }
        public string IP { get; set; }
    }
}
