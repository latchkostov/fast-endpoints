using FastEndpointsTutorial.Models;

namespace FastEndpointsTutorial.Services;

public class WeatherService : IWeatherService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherInfo GetCurrentWeather()
    {
        var random = new Random();
        var temperatureC = random.Next(-20, 55);
        var summary = Summaries[random.Next(Summaries.Length)];

        return new WeatherInfo
        {
            TemperatureC = temperatureC,
            TemperatureF = 32 + (int)(temperatureC / 0.5556),
            Summary = summary
        };
    }
}