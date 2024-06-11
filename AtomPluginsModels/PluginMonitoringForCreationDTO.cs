namespace AtomPluginsModels
{
    public record PluginMonitoringForCreationDTO
    {
        public required string PluginId { get; init; }
        public string? PluginVersion { get; init; }
        public DateTime LaunchDate { get; init; }
        public string? Username { get; init; }
        public string? ProjectName { get; init; }
        public string? UserDisplayName { get; init; }
        public string? ProgramName { get; init; }
        public string? ProgramVersion { get; init; }
    }
}