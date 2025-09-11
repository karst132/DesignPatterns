using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal abstract class BaseObservingDisplay : Observer
    {
        protected float Temperature { get; private set; } = 0;
        protected float Humidity { get; private set; } = 0;
        protected float Pressure { get; private set; } = 0;

        protected BaseObservingDisplay(Subject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public abstract void Display();

        public void Update(float temprature, float humidity, float pressure)
        {
            Temperature = temprature;
            Humidity = humidity;
            Pressure = pressure;
            Display();
        }
    }
}
