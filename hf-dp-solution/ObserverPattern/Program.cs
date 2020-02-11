using ObserverPattern.Displays;
using ObserverPattern.Interfaces;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();

            IDisplayElement currentConditionsDisplay = new CurrentConditionDisplay(wd);
            IDisplayElement statisticsDisplay = new StatisticsDisplay(wd);
            IDisplayElement forecastDisplay = new ForecastDisplay(wd);

            wd.SetMeasurements(80, 65, 30.4);
            Task.Delay(2000).Wait();
            wd.SetMeasurements(82, 70, 29.2);
            Task.Delay(2000).Wait();
            wd.SetMeasurements(78, 90, 29.2);
        }
    }
}
