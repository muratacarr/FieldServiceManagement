using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace FieldServiceManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceRequestsController : CustomBaseController
    {
        private readonly IServiceRequestService _serviceRequestService;
        public ServiceRequestsController(IServiceRequestService serviceRequestService)
        {
            _serviceRequestService = serviceRequestService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateServiceRequest(CreateServiceRequestDto createServiceRequestDto)
        {
            return ActionResultInstance(await _serviceRequestService.CreateServiceRequestAsync(createServiceRequestDto));
        }
        [HttpPost]
        public async Task<IActionResult> GetServiceRequest(GetServiceRequestDto getServiceRequestDto)
        {
            return ActionResultInstance(await _serviceRequestService.GetServiceRequestByCustomerIdAsync(getServiceRequestDto));
        }
        [HttpGet]
        public async Task<IActionResult> GetOpenServiceRequest()
        {
            return ActionResultInstance(await _serviceRequestService.GetOpenServiceRequestAsync());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStatusOfServiceRequestAsync(UpdateStatusOfServiceRequestDto updateStatusOfServiceRequestDto)
        {
            return ActionResultInstance(await _serviceRequestService.UpdateStatusOfServiceRequestAsync(updateStatusOfServiceRequestDto));
        }
    }
}
