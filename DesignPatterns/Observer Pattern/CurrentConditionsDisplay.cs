using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer_Pattern
{
    class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine(string.Format("Current conditions: {0}F degrees and {1}% humidity", temperature, humidity));
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}
