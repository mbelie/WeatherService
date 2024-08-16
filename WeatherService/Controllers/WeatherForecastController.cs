using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using WeatherService.Interfaces.Models;
using WeatherService.Interfaces.Services;

namespace WeatherService.Controllers;

[ApiController]
[Route("[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _weatherService = weatherService ?? throw new ArgumentNullException(nameof(weatherService));
    }

    [HttpGet("{latitude},{longitude}")]
    public async Task<ActionResult<IWeatherForecastResult>> Get(float latitude, float longitude)
    {
        var result = await _weatherService.GetForecast(latitude, longitude);

        return result.Error != null
            ? NotFound(result.Error)
            : Ok(result.WeatherForecast);
    }
}