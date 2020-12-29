using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbBookTopic
    {
        public int BookId { get; set; }
        public int TopicId { get; set; }

        public virtual TbBook Book { get; set; }
        public virtual TbTopic Topic { get; set; }
    }
}
