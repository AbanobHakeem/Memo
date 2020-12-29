using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbAuthourBook
    {
        public int AuthourId { get; set; }
        public int BookId { get; set; }

        public virtual TbAuthour Authour { get; set; }
        public virtual TbBook Book { get; set; }
    }
}
