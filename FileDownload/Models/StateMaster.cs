using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class StateMaster
    {
        public StateMaster()
        {
            DistrictMasters = new HashSet<DistrictMaster>();
        }

        public long StateId { get; set; }
        public string State { get; set; }

        public virtual ICollection<DistrictMaster> DistrictMasters { get; set; }
    }
}
