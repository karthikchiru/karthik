using System;
using System.Collections.Generic;

#nullable disable

namespace FileDownload.Models
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public long id { get; set; }
        public string Authority { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
