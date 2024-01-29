namespace Shared;

public interface IDataBroker
{
    public Task<IEnumerable<WeatherForecast>> GetWeatherForecastsAsync();
}
