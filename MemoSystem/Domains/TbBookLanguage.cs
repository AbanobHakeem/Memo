using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbBookLanguage
    {
        public int BookId { get; set; }
        public int LanguageId { get; set; }

        public virtual TbBook Book { get; set; }
        public virtual TbLanguage Language { get; set; }
    }
}
