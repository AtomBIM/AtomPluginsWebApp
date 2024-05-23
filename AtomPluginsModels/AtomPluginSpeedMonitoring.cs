using System.ComponentModel.DataAnnotations;

namespace AtomPluginsModels
{
    public class AtomPluginSpeedMonitoring
    {
        [Key]
        [Required]
        public string PluginId { get; set; }

        public string? PluginVersion { get; set; }
        public string? Username { get; set; }
        public string? UserDisplayName { get; set; }
        public string? ProjectName { get; set; }
        public string? ProgramName { get; set; }
        public string? ProgramVersion { get; set; }
        public string? OperationType { get; set; }
        public DateTime OperationLaunchDate { get; set; }
        public TimeSpan OperationTimeElapsed { get; set; }
        public double HandledElementsCount { get; set; }
    }
}