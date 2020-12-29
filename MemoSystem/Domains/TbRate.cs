using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbRate
    {
        public int RateId { get; set; }
        public int RateValue { get; set; }
        public int BookId { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUser ApplicationUser { get; set; }
        public virtual TbBook Book { get; set; }
    }
}
