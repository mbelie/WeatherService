namespace WeatherService.Interfaces.Configuration;

public interface IWeatherServiceConfiguration
{
    /// <summary>
    ///     Specifies the user agent to use when making requests to a weather endpoint
    /// </summary>
    string UserAgent { get; }
}