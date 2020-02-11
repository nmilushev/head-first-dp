using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern.Displays
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double avgTemperature;
        private double minTemperature = double.MaxValue;
        private double maxTemperature = double.MinValue;
        private ICollection<double> temperatures;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
            this.temperatures = new List<double>();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature: {this.avgTemperature:F1} / {this.maxTemperature:F1} / {this.minTemperature:F1}");
        }

        public void Update(double temp, double humidity, double pressure)
        {
            this.maxTemperature = temp > this.maxTemperature ? temp : this.maxTemperature;
            this.minTemperature = temp < this.minTemperature ? temp : this.minTemperature;
            this.temperatures.Add(temp);
            this.avgTemperature = this.temperatures.Average();

            this.Display();
        }
    }
}
