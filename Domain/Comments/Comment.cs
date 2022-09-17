using Domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Comments
{
  public  class Comment
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public Comment Parent { get; set; }
        public string UserId { get; set; }
        public string ConfirmedUserId { get; set; }
        public string Message { get; set; }
        public int PostId { get; set; }
        public CatalogItem Post { get; set; }
        public DateTime CommentDate { get; set; }
        public string IP { get; set; }
        public byte Status { get; set; } = 0;
        public string Image { get; set; }
    }
}
