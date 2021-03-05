using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class RefreshToken
    {
        public long Id { get; set; }
        public string Token { get; set; }
        public DateTime? Expires { get; set; }
        public DateTime? Created { get; set; }
        public long userid { get; set; }

        public virtual UserProfile user { get; set; }
    }
}
