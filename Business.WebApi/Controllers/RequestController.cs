using Business.Entity.Base;
using Business.Entity.Dto;
using Business.Entity.IBase;
using Business.Entity.Models;
using Business.Interface;
using Business.WebApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ApiBaseController<IRequestService, Request, DtoRequest>
    {
        private readonly IRequestService requestService;
        public RequestController(IRequestService requestService) : base(requestService)
        {
            this.requestService = requestService;
        }

        [HttpGet("GetJobList")]
        public IResponse<IQueryable<DtoJob>> GetJobList()
        {
            try
            {
                return requestService.GetJobList();
            }
            catch (Exception ex)
            {

                return new Response<IQueryable<DtoJob>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        [HttpPost("AddRequest")]
        public IResponse<DtoRequestCreate> AddRequest(DtoRequestCreate entity)
        {
            try
            {
                return requestService.AddRequest(entity);
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
    }
}
