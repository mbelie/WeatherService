using Newtonsoft.Json;

namespace WeatherService.Services.NationalWeatherService.Models;

public class GridPointResponseProperties
{
    [JsonProperty("@id")] public string Id { get; set; }
    [JsonProperty("forecast")] public string ForecastUrl { get; set; }
}