using System.ComponentModel.DataAnnotations;

namespace AtomPluginsModels
{
    public class AtomSyncMonitoring
    {
        public string? ProjectName { get; set; }
        public string? Username { get; set; }
        public string? UserDisplayName { get; set; }
        public string? ProgramName { get; set; }
        public string? ProgramVersion { get; set; }

        [Key]
        public DateTime Date { get; set; }
    }
}