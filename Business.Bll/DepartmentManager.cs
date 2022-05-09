using Business.Entity.Dto;
using Business.Entity.Models;
using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace Business.Bll
{
    public class DepartmentManager :GenericManager<Department,DtoDepartment> ,IDepartmentService
    {
        public DepartmentManager(IServiceProvider service):base(service)
        {

        }
    }
}
