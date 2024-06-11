namespace AtomPluginsModels
{
    public static class ModelExtensions
    {
        public static PluginMonitoring ToPluginMonitoring(this PluginMonitoringForCreationDTO dto)
        {
            return new PluginMonitoring()
            {
                PluginId = dto.PluginId,
                PluginVersion = dto.PluginVersion,
                LaunchDate = dto.LaunchDate.ToUniversalTime(),
                Username = dto.Username,
                ProjectName = dto.ProjectName,
                UserDisplayName = dto.UserDisplayName,
                ProgramName = dto.ProgramName,
                ProgramVersion = dto.ProgramVersion,
            };
        }

        public static PluginLog ToPluginLog(this PluginLogForCreationDTO atomPluginLogDTO)
        {
            return new PluginLog()
            {
                PluginId = atomPluginLogDTO.PluginId,
                PluginVersion = atomPluginLogDTO.PluginVersion,
                Username = atomPluginLogDTO.Username,
                ProjectName = atomPluginLogDTO.ProjectName,
                Level = atomPluginLogDTO.Level,
                Message = atomPluginLogDTO.Message,
                AdditionalMessage = atomPluginLogDTO.AdditionalMessage,
                Date = atomPluginLogDTO.Date.ToUniversalTime(),
                ExceptionMessage = atomPluginLogDTO.ExceptionMessage,
                ExceptionStackTrace = atomPluginLogDTO.ExceptionStackTrace,
                ClassName = atomPluginLogDTO.ClassName,
                UserDisplayName = atomPluginLogDTO.UserDisplayName,
                ProgramName = atomPluginLogDTO.ProgramName,
                ProgramVersion = atomPluginLogDTO.ProgramVersion,
            };
        }
    }
}
