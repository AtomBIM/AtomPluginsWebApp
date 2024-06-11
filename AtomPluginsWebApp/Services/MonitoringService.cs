using AtomPluginsDB;
using AtomPluginsModels;

namespace AtomPluginsWebApp.Services
{
    public class MonitoringService(ApplicationDbContext db)
    {
        private readonly ApplicationDbContext _db = db;

        public async Task<bool> CreatePluginMonitoringAsync(PluginMonitoringForCreationDTO dto)
        {
            if (dto == null)
            {
                return false;
            }

            var pluginMonitoring = dto.ToPluginMonitoring();

            _db.Monitoring.Add(pluginMonitoring);

            var result = await _db.SaveChangesAsync();
            return result == 1;
        }
    }
}