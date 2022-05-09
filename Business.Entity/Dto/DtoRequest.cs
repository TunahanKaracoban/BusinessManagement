using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoRequest : DtoBase
    {
        public DtoRequest()
        {
            
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
    }
}
