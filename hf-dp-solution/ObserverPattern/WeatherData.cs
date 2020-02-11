using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private ICollection<IObserver> observers;
        private double temperature;
        private double humidity;
        private double pressure;

        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var obeserver in this.observers)
            {
                obeserver.Update(this.temperature, this.humidity, this.pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            this.observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            bool observerExists = this.observers.Contains(o);

            if (observerExists)
            {
                this.observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.MeasurementsChanged();
        }
    }
}
