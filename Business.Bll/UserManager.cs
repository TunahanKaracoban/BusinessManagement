using Business.Dal.Abstract;
using Business.Entity.Base;
using Business.Entity.Dto;
using Business.Entity.IBase;
using Business.Entity.Models;
using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Bll
{
    public class UserManager:GenericManager<User,DtoUser>,IUserService
    {
        public readonly IUserRepository userRepository;
        private IConfiguration configuration;
        public UserManager(IServiceProvider service, IConfiguration configuration) :base(service)
        {
            userRepository = service.GetService<IUserRepository>();
            this.configuration = configuration;
        }

        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            var user = userRepository.Login(ObjectMapper.Mapper.Map<User>(login));

            if (user != null)
            {
                // token üretmek gerekiyor
                var dtouser = ObjectMapper.Mapper.Map<DtoLoginUser>(user);

                var token = new TokenManager(configuration).CreateAccessToken(dtouser);

                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtouser,
                    AccessToken = token
                };

                return new Response<DtoUserToken>
                {
                    Message = "Token üretildi",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };

            }
            else
            {
                return new Response<DtoUserToken>
                {
                    Message = "Email veya parolanız yanlış!",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
    }
}
