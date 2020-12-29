using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbComment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUser ApplicationUser { get; set; }
        public virtual TbPost Post { get; set; }
    }
}
