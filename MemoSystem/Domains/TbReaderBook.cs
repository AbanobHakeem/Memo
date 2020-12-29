using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbReaderBook
    {
        public int ReaderBookId { get; set; }
        public int BookId { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual AspNetUser ApplicationUser { get; set; }
        public virtual TbBook Book { get; set; }
    }
}
