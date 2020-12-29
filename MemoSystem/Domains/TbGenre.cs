using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbGenre
    {
        public TbGenre()
        {
            TbBookGenres = new HashSet<TbBookGenre>();
        }

        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<TbBookGenre> TbBookGenres { get; set; }
    }
}
