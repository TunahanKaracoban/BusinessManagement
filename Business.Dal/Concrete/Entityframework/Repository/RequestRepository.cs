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
    public class RequestRepository:GenericRepository<Request>,IRequestRepository
    {
        protected DbContext context;
        protected DbSet<Request> dbset;
        public RequestRepository(DbContext context) : base(context)
        {
            this.context = context;
            this.dbset = this.context.Set<Request>();

        }

        public Request AddRequest(Request item)
        {
            context.Entry(item).State = EntityState.Added;
            dbset.Add(item);
            return item;
        }

        public IQueryable<Request> GetJobList()
        {
            return dbset.AsQueryable();
        }
    }
}
