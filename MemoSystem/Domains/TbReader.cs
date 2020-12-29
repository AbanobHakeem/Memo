using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbReader
    {
        public int ReaderId { get; set; }
        public string ReaderName { get; set; }
        public string ReaderEmail { get; set; }
        public string ReaderPassword { get; set; }
        public string Quotes { get; set; }
    }
}
