using AtomPluginsModels;
using AtomPluginsWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AtomPluginsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private readonly LogsService _logsService;

        public LogsController(LogsService logsService)
        {
            _logsService = logsService;
        }

        [HttpPost]
        public async Task<IActionResult> Write(AtomPluginLogDTO atomPluginLogDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _logsService.WriteAsync(atomPluginLogDTO);
            if (result)
            {
                return Ok();
            }

            return BadRequest(result);
        }
    }
}