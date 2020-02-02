using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private ICollection<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            this._observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var obeserver in this._observers)
            {
                obeserver.Update(this._temperature, this._humidity, this._pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            this._observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            bool observerExists = this._observers.Contains(o);

            if (observerExists)
            {
                this._observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            this.MeasurementsChanged();
        }
    }
}
