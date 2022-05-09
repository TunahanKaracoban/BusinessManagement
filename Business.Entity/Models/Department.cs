using Business.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Business.Entity.Models
{
    public partial class Department:EntityBase
    {
        public Department()
        {
            Requests = new HashSet<Request>();
            Users = new HashSet<User>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
