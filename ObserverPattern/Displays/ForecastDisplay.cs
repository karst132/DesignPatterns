using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            string message = string.Empty;

            if (humidity < 50 && temperature >= 20)
            {
                message = "Good weather is comming";
            }
            else if (humidity >= 50 && temperature < 20)
            {
                message = "Watch out for cooler, rainy weather. Take a umbrella with you";
            }
            else if (humidity >= 50 && temperature >= 20)
            {
                message = "Watch out for hot, humid weather";
            }
            else
            {
                message = "Cold weather is comming";
            }

            Console.WriteLine(message);
        }
    }
}
