using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoRequestCreate: DtoBase
    {
        public string RequestHeader { get; set; }
        public int DepartmentId { get; set; }
        public string Status { get; set; }
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string Description { get; set; }
    }
}
