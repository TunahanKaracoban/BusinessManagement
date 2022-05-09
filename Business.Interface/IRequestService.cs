using Business.Entity.Dto;
using Business.Entity.Models;
using Business.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IRequestService:IGenericService<Request,DtoRequest>
    {
        IResponse<IQueryable<DtoJob>> GetJobList();
        IResponse<DtoRequestCreate> AddRequest(DtoRequestCreate item, bool saveChanges = true);
    }
}
