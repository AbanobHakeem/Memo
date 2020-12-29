using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class VwDrawBook
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ImageName { get; set; }
        public string BookIsbn { get; set; }
        public string Edition { get; set; }
        public string Summary { get; set; }
        public string FormatName { get; set; }
    }
}
