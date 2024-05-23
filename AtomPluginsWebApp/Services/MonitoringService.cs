using AtomPluginsDB;
using AtomPluginsModels;

namespace AtomPluginsWebApp.Services
{
    public class MonitoringService
    {
        private readonly ApplicationContext _db;

        public MonitoringService(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<bool> WriteAsync(AtomPluginMonitoringDTO atomPluginMonitoringDTO)
        {
            if (atomPluginMonitoringDTO == null)
            {
                return false;
            }

            var atomPluginMonitoring = atomPluginMonitoringDTO.FromDTO();

            _db.Monitoring.Add(atomPluginMonitoring);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> WriteAsync(AtomPluginSpeedMonitoringDTO atomPluginSpeedMonitoringDTO)
        {
            if (atomPluginSpeedMonitoringDTO == null)
            {
                return false;
            }

            var atomPluginSpeedMonitoring = atomPluginSpeedMonitoringDTO.FromDTO();

            _db.SpeedMonitoring.Add(atomPluginSpeedMonitoring);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> WriteAsync(AtomSyncMonitoringDTO atomSyncMonitoringDTO)
        {
            if (atomSyncMonitoringDTO == null)
            {
                return false;
            }

            var atomSyncMonitoring = atomSyncMonitoringDTO.FromDTO();

            _db.SyncMonitoring.Add(atomSyncMonitoring);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<AtomPluginMonitoringDTO>> GetAllMonitoringAsync()
        {
            return await Task.Run(() => _db.Monitoring.Select(x => x.ToDTO()));
        }
    }
}