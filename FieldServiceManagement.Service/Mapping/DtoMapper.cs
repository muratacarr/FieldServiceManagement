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
        }
    }
}
