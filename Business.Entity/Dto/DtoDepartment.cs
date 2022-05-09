using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoDepartment :DtoBase
    {
        public DtoDepartment()
        {
          
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
