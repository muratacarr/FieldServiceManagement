using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FieldServiceManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JobAssignmentsController : CustomBaseController
    {
        private readonly IJobAssignmentService _jobAssignmentService;

        public JobAssignmentsController(IJobAssignmentService jobAssignmentService)
        {
            _jobAssignmentService = jobAssignmentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetJobAssignment()
        {
            return ActionResultInstance(await _jobAssignmentService.GetJobAssignmentAsync());
        }
        [HttpPost]
        public async Task<IActionResult> CreateJobAssignment(CreateJobAssignmentDto createJobAssignmentDto)
        {
            return ActionResultInstance(await _jobAssignmentService.CreateJobAssignmentAsync(createJobAssignmentDto));
        }
    }

}
