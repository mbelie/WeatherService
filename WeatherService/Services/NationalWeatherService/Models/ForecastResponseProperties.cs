using Newtonsoft.Json;

namespace WeatherService.Services.NationalWeatherService.Models;

public class ForecastResponseProperties
{
    [JsonProperty("periods")] public Period[] Periods { get; set; }
}