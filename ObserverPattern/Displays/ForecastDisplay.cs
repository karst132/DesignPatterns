using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : BaseObservingDisplay
    {
        public ForecastDisplay(Subject weatherData) : base(weatherData)
        { 
        }

        public override void Display()
        {
            string message = string.Empty;

            if (Humidity < 50 && Temperature >= 20)
            {
                message = "Good weather is comming";
            }
            else if (Humidity >= 50 && Temperature < 20)
            {
                message = "Watch out for cooler, rainy weather. Take a umbrella with you";
            }
            else if (Humidity >= 50 && Temperature >= 20)
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
