using Business.Entity.Dto;
using Business.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IMessageService :IGenericService<Message,DtoMessage>
    {
    }
}
