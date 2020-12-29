using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbFormat
    {
        public TbFormat()
        {
            TbBooks = new HashSet<TbBook>();
        }

        public int FormatId { get; set; }
        public string FormatName { get; set; }
        public int? NumberOfbooks { get; set; }

        public virtual ICollection<TbBook> TbBooks { get; set; }
    }
}
