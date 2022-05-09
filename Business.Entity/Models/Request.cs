using Business.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Business.Entity.Models
{
    public partial class Request:EntityBase
    {
        public Request()
        {
            Messages = new HashSet<Message>();
        }

        public int RequestId { get; set; }
        public int RequestNo { get; set; }
        public string RequestHeader { get; set; }
        public string DepartmentSubject { get; set; }
        public string Status { get; set; }
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string Description { get; set; }
        public int JobOpenId { get; set; }
        public int? JobAssigmentId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual User JobAssigment { get; set; }
        public virtual User JobOpen { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
