using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.Displays
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private double pressure;
        private string displayMessage;
        private ISubject weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Forecast: " + this.displayMessage);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            SetDisplayMessage(pressure);

            this.pressure = pressure;

            this.Display();
        }

        private void SetDisplayMessage(double pressure)
        {
            if (this.pressure > pressure)
            {
                this.displayMessage = "Improving weather on the way";
            }
            else if (this.pressure < pressure)
            {
                this.displayMessage = "Watch out for cooler, rainy weather";
            }
            else
            {
                this.displayMessage = "More of the same";
            }
        }
    }
}
