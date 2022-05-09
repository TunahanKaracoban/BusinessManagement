using Business.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Business.Entity.Models
{
    public partial class User:EntityBase
    {
        public User()
        {
            MessageMessageReceivers = new HashSet<Message>();
            MessageMessageSenders = new HashSet<Message>();
            RequestJobAssigments = new HashSet<Request>();
            RequestJobOpens = new HashSet<Request>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastname { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Message> MessageMessageReceivers { get; set; }
        public virtual ICollection<Message> MessageMessageSenders { get; set; }
        public virtual ICollection<Request> RequestJobAssigments { get; set; }
        public virtual ICollection<Request> RequestJobOpens { get; set; }
    }
}
