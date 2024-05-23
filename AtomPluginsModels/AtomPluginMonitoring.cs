using System.ComponentModel.DataAnnotations;

namespace AtomPluginsModels
{
    public class AtomPluginMonitoring
    {
        [Key]
        [Required]
        public string PluginId { get; set; }

        public string? PluginVersion { get; set; }
        public DateTime LaunchDate { get; set; }
        public string? Username { get; set; }
        public string? ProjectName { get; set; }
        public string? UserDisplayName { get; set; }
        public string? ProgramName { get; set; }
        public string? ProgramVersion { get; set; }
    }
}