using AtomPluginsModels;
using AtomPluginsWebAPI.Filters;
using AtomPluginsWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AtomPluginsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoringController(MonitoringService monitoringService) : ControllerBase
    {
        private readonly MonitoringService _monitoringService = monitoringService;

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreatePluginMonitoring([FromBody] PluginMonitoringForCreationDTO dto)
        {
            var success = await _monitoringService.CreatePluginMonitoringAsync(dto);
            return success ? Ok() : BadRequest();
        }
    }
}