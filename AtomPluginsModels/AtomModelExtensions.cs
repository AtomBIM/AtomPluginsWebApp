namespace AtomPluginsModels
{
    public static class AtomModelExtensions
    {
        #region MONITORING

        public static AtomPluginMonitoring FromDTO(this AtomPluginMonitoringDTO atomPluginMonitoringDTO)
        {
            return new AtomPluginMonitoring()
            {
                PluginId = atomPluginMonitoringDTO.PluginId,
                PluginVersion = atomPluginMonitoringDTO.PluginVersion,
                LaunchDate = atomPluginMonitoringDTO.LaunchDate,
                Username = atomPluginMonitoringDTO.Username,
                ProjectName = atomPluginMonitoringDTO.ProjectName,
                UserDisplayName = atomPluginMonitoringDTO.UserDisplayName,
                ProgramName = atomPluginMonitoringDTO.ProgramName,
                ProgramVersion = atomPluginMonitoringDTO.ProgramVersion,
            };
        }

        public static AtomPluginMonitoringDTO ToDTO(this AtomPluginMonitoring atomPluginMonitoring)
        {
            return new AtomPluginMonitoringDTO()
            {
                PluginId = atomPluginMonitoring.PluginId,
                PluginVersion = atomPluginMonitoring.PluginVersion,
                LaunchDate = atomPluginMonitoring.LaunchDate,
                Username = atomPluginMonitoring.Username,
                ProjectName = atomPluginMonitoring.ProjectName,
                UserDisplayName = atomPluginMonitoring.UserDisplayName,
                ProgramName = atomPluginMonitoring.ProgramName,
                ProgramVersion = atomPluginMonitoring.ProgramVersion,
            };
        }

        public static AtomPluginSpeedMonitoring FromDTO(this AtomPluginSpeedMonitoringDTO atomPluginSpeedMonitoringDTO)
        {
            return new AtomPluginSpeedMonitoring()
            {
                PluginId = atomPluginSpeedMonitoringDTO.PluginId,
                PluginVersion = atomPluginSpeedMonitoringDTO.PluginVersion,
                Username = atomPluginSpeedMonitoringDTO.Username,
                UserDisplayName = atomPluginSpeedMonitoringDTO.UserDisplayName,
                ProjectName = atomPluginSpeedMonitoringDTO.ProjectName,
                ProgramName = atomPluginSpeedMonitoringDTO.ProgramName,
                ProgramVersion = atomPluginSpeedMonitoringDTO.ProgramVersion,
                OperationType = atomPluginSpeedMonitoringDTO.OperationType,
                OperationLaunchDate = atomPluginSpeedMonitoringDTO.OperationLaunchDate,
                OperationTimeElapsed = atomPluginSpeedMonitoringDTO.OperationTimeElapsed,
                HandledElementsCount = atomPluginSpeedMonitoringDTO.HandledElementsCount,
            };
        }

        public static AtomSyncMonitoring FromDTO(this AtomSyncMonitoringDTO atomSyncMonitoringDTO)
        {
            return new AtomSyncMonitoring()
            {
                ProjectName = atomSyncMonitoringDTO.ProjectName,
                Username = atomSyncMonitoringDTO.Username,
                UserDisplayName = atomSyncMonitoringDTO.UserDisplayName,
                ProgramName = atomSyncMonitoringDTO.ProgramName,
                ProgramVersion = atomSyncMonitoringDTO.ProgramVersion,
                Date = atomSyncMonitoringDTO.Date,
            };
        }

        public static AtomSyncMonitoringDTO ToDTO(this AtomSyncMonitoring atomSyncMonitoring)
        {
            return new AtomSyncMonitoringDTO()
            {
                ProjectName = atomSyncMonitoring.ProjectName,
                Username = atomSyncMonitoring.Username,
                UserDisplayName = atomSyncMonitoring.UserDisplayName,
                ProgramName = atomSyncMonitoring.ProgramName,
                ProgramVersion = atomSyncMonitoring.ProgramVersion,
                Date = atomSyncMonitoring.Date,
            };
        }

        #endregion

        #region LOG

        public static AtomPluginLog FromDTO(this AtomPluginLogDTO atomPluginLogDTO)
        {
            return new AtomPluginLog()
            {
                PluginId = atomPluginLogDTO.PluginId,
                PluginVersion = atomPluginLogDTO.PluginVersion,
                Username = atomPluginLogDTO.Username,
                ProjectName = atomPluginLogDTO.ProjectName,
                Level = atomPluginLogDTO.Level,
                Message = atomPluginLogDTO.Message,
                AdditionalMessage = atomPluginLogDTO.AdditionalMessage,
                Date = atomPluginLogDTO.Date,
                ExceptionMessage = atomPluginLogDTO.ExceptionMessage,
                ExceptionStackTrace = atomPluginLogDTO.ExceptionStackTrace,
                ClassName = atomPluginLogDTO.ClassName,
                UserDisplayName = atomPluginLogDTO.UserDisplayName,
                ProgramName = atomPluginLogDTO.ProgramName,
                ProgramVersion = atomPluginLogDTO.ProgramVersion,
            };
        }

        #endregion
    }
}
