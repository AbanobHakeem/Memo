using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbMediaAccount
    {
        public TbMediaAccount()
        {
            TbAdmins = new HashSet<TbAdmin>();
            TbSystemInfos = new HashSet<TbSystemInfo>();
        }

        public int MediaId { get; set; }
        public string FaceBook { get; set; }
        public string GooglePlus { get; set; }
        public string Youtube { get; set; }
        public string Twiter { get; set; }
        public string Linkedin { get; set; }

        public virtual ICollection<TbAdmin> TbAdmins { get; set; }
        public virtual ICollection<TbSystemInfo> TbSystemInfos { get; set; }
    }
}
