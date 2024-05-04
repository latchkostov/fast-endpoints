using FastEndpointsTutorial.Models;

namespace FastEndpointsTutorial.Services;

public interface IWeatherService
{
    WeatherInfo GetCurrentWeather();
}