using Business.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Business.Entity.Models
{
    public partial class Message:EntityBase
    {
        public int MessageId { get; set; }
        public string Message1 { get; set; }
        public int? MessageSenderId { get; set; }
        public int? MessageReceiverId { get; set; }
        public int? RequestId { get; set; }

        public virtual User MessageReceiver { get; set; }
        public virtual User MessageSender { get; set; }
        public virtual Request Request { get; set; }
    }
}
