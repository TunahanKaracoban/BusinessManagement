using AutoMapper;
using Business.Entity.Dto;
using Business.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DtoDepartment>().ReverseMap();
            CreateMap<Message, DtoMessage>().ReverseMap();
            CreateMap<Role, DtoRole>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
            CreateMap<DtoJob, Request>().ReverseMap();
            CreateMap<Request, DtoRequest>().ReverseMap();
            CreateMap<DtoRequestCreate, Request>().ReverseMap();
            CreateMap<User, DtoLoginUser>();
            CreateMap<DtoLogin, User>();
        }
    }
}
