using Business.Entity.Base;
using Business.Entity.Dto;
using Business.Entity.IBase;
using Business.Entity.Models;
using Business.Interface;
using Business.WebApi.Base;
using Microsoft.AspNetCore.Authorization;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            try
            {
                return userService.Login(login);
            }
            catch (Exception ex)
            {

                return new Response<DtoUserToken>()
                {
                    Message = "Error" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null

                };
            }
        }
    }
}
