using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbPublisher
    {
        public TbPublisher()
        {
            TbPublisherBooks = new HashSet<TbPublisherBook>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherBio { get; set; }

        public virtual ICollection<TbPublisherBook> TbPublisherBooks { get; set; }
    }
}
