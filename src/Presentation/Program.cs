using CleanArchitectureImplementation.Application;
using CleanArchitectureImplementation.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add layer depencies
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.Run();
