using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbBookGenre
    {
        public int BookId { get; set; }
        public int GenreId { get; set; }

        public virtual TbBook Book { get; set; }
        public virtual TbGenre Genre { get; set; }
    }
}
