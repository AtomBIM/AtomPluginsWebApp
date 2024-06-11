using AtomPluginsDB;
using AtomPluginsModels;

namespace AtomPluginsWebApp.Services
{
    public class LogsService(ApplicationDbContext db)
    {
        private readonly ApplicationDbContext _db = db;

        public async Task<bool> CreatePluginLogAsync(PluginLogForCreationDTO dto)
        {
            if (dto == null)
            {
                return false;
            }

            var pluginLog = dto.ToPluginLog();

            _db.Logs.Add(pluginLog);

            var result = await _db.SaveChangesAsync();
            return result == 1;
        }
        
    }
}