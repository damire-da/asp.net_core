var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
IServiceCollection services = builder.Services; 

app.MapGet("/", () => "Hello World!");

app.Run();
app.ToString();