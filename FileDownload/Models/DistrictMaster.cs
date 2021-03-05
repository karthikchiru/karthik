using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class DistrictMaster
    {
        public long DistrictId { get; set; }
        public string DistrictName { get; set; }
        public long StateId { get; set; }

        public virtual StateMaster State { get; set; }
    }
}
