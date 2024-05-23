using AtomPluginsDB;
using AtomPluginsModels;

namespace AtomPluginsWebApp.Services
{
    public class LogsService
    {
        private readonly ApplicationContext _db;

        public LogsService(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<bool> WriteAsync(AtomPluginLogDTO atomPluginLogDTO)
        {
            if (atomPluginLogDTO == null)
            {
                return false;
            }

            var atomPluginLog = atomPluginLogDTO.FromDTO();

            _db.Logs.Add(atomPluginLog);
            await _db.SaveChangesAsync();
            return true;
        }

        
    }
}