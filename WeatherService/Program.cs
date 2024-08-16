using WeatherService;
using WeatherService.Configuration;
using WeatherService.Http;
using WeatherService.Interfaces.Http;
using WeatherService.Interfaces.Services;
using NationalWeatherService = WeatherService.Services.NationalWeatherService.WeatherService;

var builder = WebApplication.CreateBuilder(args);

var serviceConfiguration = builder.Configuration.GetSection("WeatherService").Get<WeatherServiceConfiguration>();

// One instance to limit socket usage
var httpClient = new HttpClient();
var headers = new List<KeyValuePair<string, string>>
    { new(Constants.UserAgentHeaderName, serviceConfiguration.UserAgent) };

// Add services to the container.
builder.Services.AddSingleton<IHttpClient>(new HttpClientWrapper(httpClient, headers));

// Could swap this out for any other concrete of IWeatherService
builder.Services.AddSingleton<IWeatherService, NationalWeatherService>();

builder.Services.AddControllers().AddNewtonsoftJson();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();