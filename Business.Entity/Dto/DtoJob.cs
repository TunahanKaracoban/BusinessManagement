using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoJob : DtoBase
    {
        public int RequestId { get; set; }
        public int RequestNo { get; set; }
        public string RequestHeader { get; set; }
        public int DepartmentId { get; set; }
        public DateTime? JobStartDate { get; set; }
        public int? JobAssigmentId { get; set; }
    }
}
