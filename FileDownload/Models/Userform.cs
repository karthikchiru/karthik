using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class Userform
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string MoblieNumber { get; set; }
        public string EmailId { get; set; }
        public string Qualification { get; set; }
        public string AadharCardNumber { get; set; }
        public string Address { get; set; }
        public bool CSCID { get; set; }
        public int? CSC_ID_Number { get; set; }
        public bool BCID { get; set; }
        public int? BC_ID_Number { get; set; }
        public bool CSPID { get; set; }
        public int? CSP_ID_Number { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Taluk { get; set; }
        public int PinCode { get; set; }
        public string PanNumber { get; set; }
        public bool TermsCondition { get; set; }
        public bool? formVerified { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? IsActice { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? HasRequested { get; set; }
        public long userid { get; set; }

        public virtual UserProfile user { get; set; }
    }
}
