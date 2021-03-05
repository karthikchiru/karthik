using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            OTPs = new HashSet<OTP>();
            Payments = new HashSet<Payment>();
            RefreshTokens = new HashSet<RefreshToken>();
            UserRoles = new HashSet<UserRole>();
            Userforms = new HashSet<Userform>();
        }

        public long Userid { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Enabled { get; set; }
        public string RoleType { get; set; }

        public virtual ICollection<OTP> OTPs { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Userform> Userforms { get; set; }
    }
}
