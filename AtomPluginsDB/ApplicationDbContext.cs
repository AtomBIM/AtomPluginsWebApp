using AtomPluginsDB.Configurations;
using AtomPluginsModels;
using Microsoft.EntityFrameworkCore;

namespace AtomPluginsDB
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<PluginMonitoring> Monitoring { get; set; }
        public DbSet<PluginLog> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PluginMonitoringConfiguration());
            modelBuilder.ApplyConfiguration(new PluginLogConfiguration());
        }
    }
}