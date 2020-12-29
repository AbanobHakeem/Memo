using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbTopic
    {
        public TbTopic()
        {
            TbBookTopics = new HashSet<TbBookTopic>();
        }

        public int TopicId { get; set; }
        public string TopicName { get; set; }

        public virtual ICollection<TbBookTopic> TbBookTopics { get; set; }
    }
}
