using AtomPluginsModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AtomPluginsDB.Configurations
{
    public class PluginMonitoringConfiguration : IEntityTypeConfiguration<PluginMonitoring>
    {
        public void Configure(EntityTypeBuilder<PluginMonitoring> builder)
        {
            builder.ToTable("monitoring");

            builder.Property(x => x.PluginId).HasColumnName("plugin_id");
            builder.Property(x => x.PluginVersion).HasColumnName("plugin_version");
            builder.Property(x => x.LaunchDate).HasColumnName("launch_date");
            builder.Property(x => x.Username).HasColumnName("username");
            builder.Property(x => x.ProjectName).HasColumnName("project_name");
            builder.Property(x => x.UserDisplayName).HasColumnName("user_display_name");
            builder.Property(x => x.ProgramName).HasColumnName("program_name");
            builder.Property(x => x.ProgramVersion).HasColumnName("program_version");
        }
    }
}
