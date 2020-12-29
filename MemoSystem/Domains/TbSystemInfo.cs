using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class TbSystemInfo
    {
        public int SystemId { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string WebsiteEmai { get; set; }
        public string InfoEmail { get; set; }
        public string SupportEmail { get; set; }
        public string GoogleMapsAddres { get; set; }
        public int? MediaId { get; set; }

        public virtual TbMediaAccount Media { get; set; }
    }
}
