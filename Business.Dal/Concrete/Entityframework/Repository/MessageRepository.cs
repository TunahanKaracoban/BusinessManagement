using Business.Dal.Abstract;
using Business.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dal.Concrete.Entityframework.Repository
{
    public class MessageRepository:GenericRepository<Message>,IMessageRepository
    {
        public MessageRepository(DbContext context) : base(context)
        {

        }
    }
}
