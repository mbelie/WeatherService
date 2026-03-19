using Microsoft.Extensions.Logging;
using Moq;
using WeatherService.Controllers;
using WeatherService.Interfaces.Services;

namespace WeatherService.Test.ControllersTests;

[TestClass]
public class WeatherForecastControllerTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void LoggerIsNullTest()
    {
        var weatherService = new Mock<IWeatherService>().Object;
        var target = new WeatherForecastController(null, weatherService);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void WeatherServiceIsNullTest()
    {
        var logger = new Mock<ILogger<WeatherForecastController>>().Object;
        var target = new WeatherForecastController(logger, null);
    }
}
