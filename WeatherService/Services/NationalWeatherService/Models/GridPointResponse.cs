using Newtonsoft.Json;

namespace WeatherService.Services.NationalWeatherService.Models;

public class GridPointResponse
{
    [JsonProperty("properties")] public GridPointResponseProperties Properties { get; set; }
}