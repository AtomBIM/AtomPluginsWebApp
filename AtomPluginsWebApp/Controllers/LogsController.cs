using AtomPluginsModels;
using AtomPluginsWebAPI.Filters;
using AtomPluginsWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AtomPluginsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController(LogsService logsService) : ControllerBase
    {
        private readonly LogsService _logsService = logsService;

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreatePluginLog([FromBody] PluginLogForCreationDTO dto)
        {
            var success = await _logsService.CreatePluginLogAsync(dto);
            return success ? Ok() : BadRequest();
        }
    }
}