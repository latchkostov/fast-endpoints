using FastEndpoints;
using FastEndpointsTutorial.Services;
using Microsoft.AspNetCore.Authorization;

namespace FastEndpointsTutorial;

[HttpGet("weather")]
[AllowAnonymous]
public class GetWeatherEndpoint : EndpointWithoutRequest
{
    private readonly IWeatherService _weatherService;
    
    public GetWeatherEndpoint(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }
    
    public override async Task HandleAsync(CancellationToken ct)
    {
        var weatherInfo = _weatherService.GetCurrentWeather();
        
        await SendAsync(weatherInfo);
    }
}