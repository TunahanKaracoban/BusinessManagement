using Business.Entity.Dto;
using Business.Entity.IBase;
using Business.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IUserService:IGenericService<User,DtoUser>
    {
        IResponse<DtoUserToken> Login(DtoLogin login);
    }
}
