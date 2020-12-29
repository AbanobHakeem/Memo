using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbPost
    {
        public TbPost()
        {
            TbComments = new HashSet<TbComment>();
        }

        public int PostId { get; set; }
        public int BookId { get; set; }
        public string ApplicationUserId { get; set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public int ViewsNumber { get; set; }
        public int LikesNumber { get; set; }
        public DateTime Date { get; set; }

        public virtual AspNetUser ApplicationUser { get; set; }
        public virtual TbBook Book { get; set; }
        public virtual ICollection<TbComment> TbComments { get; set; }
    }
}
