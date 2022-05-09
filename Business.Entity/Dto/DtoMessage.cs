using Business.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Dto
{
    public class DtoMessage :DtoBase
    {
        public int MessageId { get; set; }
        public string Message1 { get; set; }
        public int? MessageSenderId { get; set; }
        public int? MessageReceiverId { get; set; }
        public int? JobId { get; set; }
    }
}
