using AtomPluginsModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AtomPluginsDB.Configurations
{
    public class PluginLogConfiguration : IEntityTypeConfiguration<PluginLog>
    {
        public void Configure(EntityTypeBuilder<PluginLog> builder)
        {
            builder.ToTable("log");

            builder.Property(x => x.PluginId).HasColumnName("plugin_id");
            builder.Property(x => x.PluginVersion).HasColumnName("plugin_version");
            builder.Property(x => x.Username).HasColumnName("username");
            builder.Property(x => x.ProjectName).HasColumnName("project_name");
            builder.Property(x => x.Level).HasColumnName("level");
            builder.Property(x => x.Message).HasColumnName("message");
            builder.Property(x => x.AdditionalMessage).HasColumnName("additional_message");
            builder.Property(x => x.Date).HasColumnName("date");
            builder.Property(x => x.ExceptionMessage).HasColumnName("exception_message");
            builder.Property(x => x.ExceptionStackTrace).HasColumnName("exception_stack_trace");
            builder.Property(x => x.ClassName).HasColumnName("class_name");
            builder.Property(x => x.UserDisplayName).HasColumnName("user_display_name");
            builder.Property(x => x.ProgramName).HasColumnName("program_name");
            builder.Property(x => x.ProgramVersion).HasColumnName("program_version");
        }
    }
}
