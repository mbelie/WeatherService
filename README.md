# WeatherService

## Summary
A .NET Core 8.0 Web API project that demonstrates a REST endpoint that serves weather forecasts given a latitude/longitude pair

## Projects
- WeatherService
  - A .NET Core Web API project that hosts a single WeatherForecastController
  - Contains weather-related interfaces, types, and services including an IWeatherService implementation that interacts with the National Weather Service API
- WeatherService.Tests
   - An MSTest test project for the WeatherService namespace
   - The project is stubbed out for future completion

## Instructions
- Clone or download the repo
- In appsettings.json, specify a UserAgent value or leave as is (the defaults work)
- Open the solution in Visual Studio 2022 and build
- Ensure that the WeatherService project is set as the startup project
- Press F5 and a browser instance will launch with a Swagger UI
- Use the Swagger UI presented to test the WeatherForecast endpoint
   - Expand the collapsible panel for the endpoint 
   - Press the `Try it out` button
   - Enter values for latitude and longitude
   - Press the `execute` button
   - The Swagger UI will display a server response with one of two status codes/response bodies:
      - 404: The weather service couldn't find data for the given latitude/longitude and the response body contains error information
      - 200: Weather data was found and is displayed as JSON
- Alternatives to Swagger UI (after running the project in Visual Studio)
   - Open any browser and enter this url format: ht<span>tps://</span>localhost:&lt;running port&gt;/WeatherForecast/&lt;latitude&gt;,&lt;latitude&gt;. Be sure to replace the port, latitude, and longitude with actual values
   - Example: `https://localhost:7228/WeatherForecast/42.3943,-122.576`
   - Postman is another good option for testing this endpoint