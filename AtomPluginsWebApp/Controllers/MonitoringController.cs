using AtomPluginsModels;
using AtomPluginsWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AtomPluginsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoringController : ControllerBase
    {
        private readonly MonitoringService _monitoringService;

        public MonitoringController(MonitoringService monitoringService)
        {
            _monitoringService = monitoringService;
        }

        [HttpPost]
        public async Task<IActionResult> Write(AtomPluginMonitoringDTO atomPluginMonitoringDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _monitoringService.WriteAsync(atomPluginMonitoringDTO);
            if (result)
            {
                return Ok();
            }

            return BadRequest(result);
        }

        [HttpPost("speed")]
        public async Task<IActionResult> Write(AtomPluginSpeedMonitoringDTO atomPluginSpeedMonitoringDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _monitoringService.WriteAsync(atomPluginSpeedMonitoringDTO);
            if (result)
            {
                return Ok();
            }

            return BadRequest(result);
        }

        [HttpPost("sync")]
        public async Task<IActionResult> Write(AtomSyncMonitoringDTO atomSyncMonitoringDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _monitoringService.WriteAsync(atomSyncMonitoringDTO);
            if (result)
            {
                return Ok();
            }

            return BadRequest(result);
        }

        //[HttpGet("all")]
        //public async Task<ActionResult<IList<AtomPluginMonitoringDTO>>> GetAllMonitoring()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var monitoring = await _monitoringService.GetAllMonitoringAsync();
        //    return Ok(monitoring);
        //}
    }
}