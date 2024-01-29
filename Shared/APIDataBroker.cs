namespace Shared;

public class APIDataBroker : IDataBroker
{
    public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync()
    {
        await Task.Yield();
        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToList();

        return forecasts;
    }
}
