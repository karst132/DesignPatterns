using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : BaseObservingDisplay
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;

        public StatisticsDisplay(Subject weatherData) : base(weatherData)
        {
        }

        public override void Display()
        {
            countUpdated++;
            sumTemperature += Temperature;
            if (Temperature > maxTemp || countUpdated == 1)
            {
                maxTemp = Temperature;
            }

            if (Temperature < minTemp || countUpdated == 1)
            {
                minTemp = Temperature;
            }

            float averageTemrature = sumTemperature / countUpdated;
            Console.WriteLine($"The average temrature is {averageTemrature}, the minimum temrature is {minTemp}, the maximum is {maxTemp}");
        }
    }
}
