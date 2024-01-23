using FieldServiceManagement.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Core.Services
{
    public interface IServiceRequestService
    {
        Task<Response<ServiceRequestDto>> CreateServiceRequestAsync(CreateServiceRequestDto createServiceRequestDto);
        Task<Response<List<ServiceRequestDto>>> GetServiceRequestByCustomerIdAsync(GetServiceRequestDto getServiceRequestDto);
        Task<Response<List<ServiceRequestDto>>> GetOpenServiceRequestAsync();
    }
}
