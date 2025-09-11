using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        { 
            weatherData.RegisterObserver(this);
            this.weatherData = weatherData;
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            Display();
        }

        public void Display()
        {
            countUpdated++;
            sumTemperature += temperature;
            if (temperature > maxTemp || countUpdated == 1)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp || countUpdated == 1)
            {
                minTemp = temperature;
            }

            float averageTemrature = sumTemperature / countUpdated;
            Console.WriteLine($"The average temrature is {averageTemrature}, the minimum temrature is {minTemp}, the maximum is {maxTemp}");
        }
    }
}
