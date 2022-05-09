using Business.Dal.Abstract;
using Business.Entity.Dto;
using Business.Entity.IBase;
using Business.Entity.Models;
using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Business.Entity.Base;
using Microsoft.AspNetCore.Http;

namespace Business.Bll
{
    public class RequestManager:GenericManager<Request,DtoRequest>,IRequestService
    {
        public readonly IRequestRepository requestRepository;
        public RequestManager(IServiceProvider service):base(service)
        {
            requestRepository = service.GetService<IRequestRepository>();
        }

        public IResponse<DtoRequestCreate> AddRequest(DtoRequestCreate item, bool saveChanges = true)
        {
            try
            {
               
                var model = ObjectMapper.Mapper.Map<Request>(item);
              
                var result = requestRepository.AddRequest(model);
                if (saveChanges)
                    Save(); 

               
                return new Response<DtoRequestCreate>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<Request, DtoRequestCreate>(result)
                };

            }
            catch (Exception ex)
            {
             
                return new Response<DtoRequestCreate>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public IResponse<IQueryable<DtoJob>> GetJobList()
        {
            try
            {
                var list = requestRepository.GetJobList();
                var listDto = list.Select(x => ObjectMapper.Mapper.Map<DtoJob>(x));

                return new Response<IQueryable<DtoJob>>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = listDto
                };
            }
            catch (Exception ex)
            {

                return new Response<IQueryable<DtoJob>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                }; ;
            }
        }
    }
}
