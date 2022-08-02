
using MinimalAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServiceCollection();
var app = builder.Build();
app.ConfigureWebApplication()
.Run();

