using ObserverPattern.Displays;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CustomList<Observer> observers = new CustomList<Observer>()
            {
                new CurrentConditionDisplay(weatherData),
                new StatisticsDisplay(weatherData),
                new ForecastDisplay(weatherData)
            };

            weatherData.SetMeasurements(21, 55, 30.4f);
            Console.WriteLine();
            weatherData.SetMeasurements(22, 48, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(19, 51, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(18, 47, 29.4f);
            Console.WriteLine();

            if (observers.TryGet(0, out Observer? observer))
            {
                weatherData.RemoveObserver(observer!);
            }

            weatherData.SetMeasurements(25, 40, 29.2f);
        }
    }
}