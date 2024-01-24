using FieldServiceManagement.Core.Services;
using FieldServiceManagement.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FieldServiceManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StatusesController : CustomBaseController
    {
        private readonly IStatusService _statusService;

        public StatusesController(IStatusService statusService)
        {
            _statusService = statusService;
        }
        [HttpGet]
        public async Task<IActionResult> GetStatuses()
        {
            return ActionResultInstance(await _statusService.GetStatusesAsync());
        }
    }
}
