using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class PasswordResetToken
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
