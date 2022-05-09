using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoLoginUser:DtoBase
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastname { get; set; }

        public string UserEmail { get; set; }
    }
}
