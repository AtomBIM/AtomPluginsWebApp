namespace AtomPluginsModels
{
    public record PluginLogForCreationDTO
    {
        public required string PluginId { get; init; }
        public string? PluginVersion { get; init; }
        public string? Username { get; init; }
        public string? ProjectName { get; init; }
        public string? Level { get; init; }
        public string? Message { get; init; }
        public string? AdditionalMessage { get; init; }
        public DateTime Date { get; init; }
        public string? ExceptionMessage { get; init; }
        public string? ExceptionStackTrace { get; init; }
        public string? ClassName { get; init; }
        public string? UserDisplayName { get; init; }
        public string? ProgramName { get; init; }
        public string? ProgramVersion { get; init; }
    }
}
