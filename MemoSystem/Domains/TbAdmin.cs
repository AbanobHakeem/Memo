using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbAdmin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminBio { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public string AdminImageName { get; set; }
        public int? MediaId { get; set; }

        public virtual TbMediaAccount Media { get; set; }
    }
}
