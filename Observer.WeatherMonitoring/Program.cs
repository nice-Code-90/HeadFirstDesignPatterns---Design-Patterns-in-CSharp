using Observer.WeatherMonitoring.Observers;
using Observer.WeatherMonitoring.Subjects;

public class WeatherStation
{
    public static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
        ForecastDisplay forecastDisplay = new ForecastDisplay();
        HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay();

        currentDisplay.Subscribe(weatherData);
        statisticsDisplay.Subscribe(weatherData);
        forecastDisplay.Subscribe(weatherData);
        heatIndexDisplay.Subscribe(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 70, 29.2f);
        weatherData.SetMeasurements(78, 90, 29.2f);

        currentDisplay.Unsubscribe();
        statisticsDisplay.Unsubscribe();
        forecastDisplay.Unsubscribe();
        heatIndexDisplay.Unsubscribe();
    }
}