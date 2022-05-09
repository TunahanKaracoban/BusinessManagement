using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoLogin:DtoBase
    {
        [Required]
        [StringLength(maximumLength:40)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(maximumLength: 10)]
        public string UserPassword { get; set; }
    }
}
