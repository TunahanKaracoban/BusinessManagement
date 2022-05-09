using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoRole :DtoBase
    {
        public DtoRole()
        {
            
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
