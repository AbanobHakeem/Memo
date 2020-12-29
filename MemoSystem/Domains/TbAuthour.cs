using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbAuthour
    {
        public TbAuthour()
        {
            TbAuthourBooks = new HashSet<TbAuthourBook>();
        }

        public int AuthourId { get; set; }
        public string AuthourName { get; set; }
        public string AuthourBio { get; set; }

        public virtual ICollection<TbAuthourBook> TbAuthourBooks { get; set; }
    }
}
