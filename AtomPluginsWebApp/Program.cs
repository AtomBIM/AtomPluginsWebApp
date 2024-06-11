using AtomPluginsWebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureIISIntegration();

builder.Services.AddControllers();

builder.Services.ConfigureApiBehavior();
builder.Services.ConfigureFilters();

builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.ConfigureModelsServices();

var app = builder.Build();

app.MapControllers();

app.Run();