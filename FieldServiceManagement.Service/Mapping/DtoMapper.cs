using AutoMapper;
using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Service.Mapping
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<AppUserDto, AppUser>().ReverseMap();
            CreateMap<AppUserForServiceRequestDto, AppUser>().ReverseMap();
            CreateMap<GetUserByRoleDto, AppUser>().ReverseMap();
            CreateMap<ServiceRequest, ServiceRequestDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<JobAssignment, JobAssignmentDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Status, StatusDto>().ReverseMap();
            CreateMap<ZoneDto, Zone>().ReverseMap();

        }
    }
}
