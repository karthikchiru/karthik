using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class UserRole
    {
        public long id { get; set; }
        public long RoleId { get; set; }
        public long UserId { get; set; }

        public virtual Role Role { get; set; }
        public virtual UserProfile User { get; set; }
    }
}
