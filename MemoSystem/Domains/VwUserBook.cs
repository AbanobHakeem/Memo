using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class VwUserBook
    {
        public string Id { get; set; }
        public int ReaderBookId { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string ImageName { get; set; }
        public string BookIsbn { get; set; }
        public string Edition { get; set; }
        public string Summary { get; set; }
    }
}
