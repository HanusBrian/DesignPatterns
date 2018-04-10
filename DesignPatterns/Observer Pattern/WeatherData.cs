using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer_Pattern
{
    class WeatherData : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;
        private float pressure;
        public void notifyObservers()
        {
            foreach (var o in observers)
            {
                o.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            if (observers.Exists(x => x == o))
                observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}

