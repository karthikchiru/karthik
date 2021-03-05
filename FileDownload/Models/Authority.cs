using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class Authority
    {
        public long id { get; set; }
        public string Role_Admin { get; set; }
        public string Role_StateHead { get; set; }
        public string Role_DistrictHead { get; set; }
        public string Role_User { get; set; }
    }
}
