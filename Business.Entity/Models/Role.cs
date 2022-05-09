using Business.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Business.Entity.Models
{
    public partial class Role:EntityBase
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
