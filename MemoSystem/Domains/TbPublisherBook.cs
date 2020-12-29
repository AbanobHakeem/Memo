using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbPublisherBook
    {
        public int PublisherId { get; set; }
        public int BookId { get; set; }

        public virtual TbBook Book { get; set; }
        public virtual TbPublisher Publisher { get; set; }
    }
}
