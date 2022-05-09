using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoUser :DtoBase
    {
        public DtoUser()
        {
            
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastname { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }

    }
}
