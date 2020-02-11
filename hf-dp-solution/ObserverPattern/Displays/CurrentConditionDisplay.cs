using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.Displays
{
    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private double temperature;
        private double humidity;
        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {this.temperature:F1} F degrees and {this.humidity:F1} % humidity");
        }

        public void Update(double temp, double humidity, double pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.Display();
        }
    }
}
