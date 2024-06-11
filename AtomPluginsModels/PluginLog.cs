using System.ComponentModel.DataAnnotations;

namespace AtomPluginsModels
{
    public class PluginLog
    {
        [Key]
        [Required]
        public string PluginId { get; set; }

        public string? PluginVersion { get; set; }
        public string? Username { get; set; }
        public string? ProjectName { get; set; }
        public string? Level { get; set; }
        public string? Message { get; set; }
        public string? AdditionalMessage { get; set; }
        public DateTime Date { get; set; }
        public string? ExceptionMessage { get; set; }
        public string? ExceptionStackTrace { get; set; }
        public string? ClassName { get; set; }
        public string? UserDisplayName { get; set; }
        public string? ProgramName { get; set; }
        public string? ProgramVersion { get; set; }
    }
}