using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class Payment
    {
        public long Paymentid { get; set; }
        public int StateMaster { get; set; }
        public int DistrictMaster { get; set; }
        public int Amount { get; set; }
        public long Userid { get; set; }
        public int Phone_pay_Number { get; set; }
        public int Google_pay_Number { get; set; }
        public string UPI_id { get; set; }
        public byte[] QR_Code { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
