using AtomPluginsModels;
using Microsoft.EntityFrameworkCore;

namespace AtomPluginsDB
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<AtomPluginMonitoring> Monitoring { get; set; }
        public DbSet<AtomPluginLog> Logs { get; set; }
        public DbSet<AtomPluginSpeedMonitoring> SpeedMonitoring { get; set; }
        public DbSet<AtomSyncMonitoring> SyncMonitoring { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtomPluginMonitoring>(b =>
            {
                b.ToTable("monitoring");

                b.Property(x => x.PluginId).HasColumnName("plugin_id");
                b.Property(x => x.PluginVersion).HasColumnName("plugin_version");
                b.Property(x => x.LaunchDate).HasColumnName("launch_date");
                b.Property(x => x.Username).HasColumnName("username");
                b.Property(x => x.ProjectName).HasColumnName("project_name");
                b.Property(x => x.UserDisplayName).HasColumnName("user_display_name");
                b.Property(x => x.ProgramName).HasColumnName("program_name");
                b.Property(x => x.ProgramVersion).HasColumnName("program_version");
            });

            modelBuilder.Entity<AtomPluginLog>(b =>
            {
                b.ToTable("log");

                b.Property(x => x.PluginId).HasColumnName("plugin_id");
                b.Property(x => x.PluginVersion).HasColumnName("plugin_version");
                b.Property(x => x.Username).HasColumnName("username");
                b.Property(x => x.ProjectName).HasColumnName("project_name");
                b.Property(x => x.Level).HasColumnName("level");
                b.Property(x => x.Message).HasColumnName("message");
                b.Property(x => x.AdditionalMessage).HasColumnName("additional_message");
                b.Property(x => x.Date).HasColumnName("date");
                b.Property(x => x.ExceptionMessage).HasColumnName("exception_message");
                b.Property(x => x.ExceptionStackTrace).HasColumnName("exception_stack_trace");
                b.Property(x => x.ClassName).HasColumnName("class_name");
                b.Property(x => x.UserDisplayName).HasColumnName("user_display_name");
                b.Property(x => x.ProgramName).HasColumnName("program_name");
                b.Property(x => x.ProgramVersion).HasColumnName("program_version");
            });

            modelBuilder.Entity<AtomPluginSpeedMonitoring>(b =>
            {
                b.ToTable("speed_monitoring");

                b.Property(x => x.PluginId).HasColumnName("plugin_id");
                b.Property(x => x.PluginVersion).HasColumnName("plugin_version");
                b.Property(x => x.Username).HasColumnName("username");
                b.Property(x => x.UserDisplayName).HasColumnName("user_display_name");
                b.Property(x => x.ProjectName).HasColumnName("project_name");
                b.Property(x => x.ProgramName).HasColumnName("program_name");
                b.Property(x => x.ProgramVersion).HasColumnName("program_version");
                b.Property(x => x.OperationType).HasColumnName("operation_type");
                b.Property(x => x.OperationLaunchDate).HasColumnName("operation_laucn_date");
                b.Property(x => x.OperationTimeElapsed).HasColumnName("operation_time_elapsed");
                b.Property(x => x.HandledElementsCount).HasColumnName("handled_elements_count");
            });

            modelBuilder.Entity<AtomSyncMonitoring>(b =>
            {
                b.ToTable("synchronization_monitoring");

                b.Property(x => x.ProjectName).HasColumnName("project_name");
                b.Property(x => x.Username).HasColumnName("username");
                b.Property(x => x.UserDisplayName).HasColumnName("user_display_name");
                b.Property(x => x.ProgramName).HasColumnName("program_name");
                b.Property(x => x.ProgramVersion).HasColumnName("program_version");
                b.Property(x => x.Date).HasColumnName("date");
            });
        }
    }
}