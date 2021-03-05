using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class OTP
    {
        public long id { get; set; }
        public string emailid { get; set; }
        public int otp1 { get; set; }
        public DateTime Createtime { get; set; }
        public long Userid { get; set; }
        public string Token { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
