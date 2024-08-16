using WeatherService.Interfaces.Configuration;

namespace WeatherService.Configuration;

public class WeatherServiceConfiguration : IWeatherServiceConfiguration
{
    public string UserAgent { get; init; }
}