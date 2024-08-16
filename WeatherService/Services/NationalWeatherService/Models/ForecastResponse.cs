using Newtonsoft.Json;

namespace WeatherService.Services.NationalWeatherService.Models;

public class ForecastResponse
{
    [JsonProperty("properties")] public ForecastResponseProperties Properties { get; set; }
}