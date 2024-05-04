using FastEndpoints;
using FastEndpoints.Swagger;
using FastEndpointsTutorial.Services;

var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints(c =>
{
    c.Assemblies = new[] { typeof(Program).Assembly };
});
builder.Services.SwaggerDocument();

builder.Services.AddTransient<IWeatherService, WeatherService>();

var app = builder.Build();

app.UseFastEndpoints();
app.UseSwaggerGen();

app.Run();