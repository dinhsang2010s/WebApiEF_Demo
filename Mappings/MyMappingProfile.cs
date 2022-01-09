using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Dtos;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Mappings
{
    public class MyMappingProfile: Profile
    {
        public MyMappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>()
                .ForMember(des=> des.Name, source=> source.MapFrom(y=>y.Name))
                .ReverseMap();
        }
    }
}
