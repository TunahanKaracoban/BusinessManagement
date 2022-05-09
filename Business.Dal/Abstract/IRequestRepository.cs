using Business.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dal.Abstract
{
    public interface IRequestRepository
    {
        IQueryable<Request> GetJobList();

        Request AddRequest(Request item);
    }
}
