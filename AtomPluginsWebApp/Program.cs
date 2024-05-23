using AtomPluginsDB;
using AtomPluginsWebApp.Services;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using System.IO.Compression;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseIISIntegration();

builder.Services.AddControllers();
builder.Services.AddTransient<MonitoringService>();
builder.Services.AddTransient<LogsService>();

builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
    options.Providers.Add<BrotliCompressionProvider>();
    options.Providers.Add<GzipCompressionProvider>();
});

builder.Services.Configure<BrotliCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.Fastest;
});

builder.Services.Configure<GzipCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.Fastest;
});

var app = builder.Build();

app.UseResponseCompression();

app.UseRouting();
app.MapControllers();

app.Run();