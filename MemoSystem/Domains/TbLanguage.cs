using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbLanguage
    {
        public TbLanguage()
        {
            TbBookLanguages = new HashSet<TbBookLanguage>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<TbBookLanguage> TbBookLanguages { get; set; }
    }
}
