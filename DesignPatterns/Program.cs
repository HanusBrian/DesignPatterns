using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Decorator;
using DesignPatterns.Strategy;
using DesignPatterns.Observer_Pattern;

namespace DesignPatterns
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Using ObserverPattern
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay display = new CurrentConditionsDisplay(weatherData);
            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);
            #endregion

            #region Using Strategy pattern
            Duck duck = new Duck();
            duck.setFlyBehavior(new FlyWithWings());
            duck.setQuackBehavior(new Quack());
            duck.performFly();
            duck.performQuack();

            Duck duck2 = new Duck();
            duck2.setFlyBehavior(new FlyWithWings());
            duck2.setQuackBehavior(new Squeakcs());
            duck2.performQuack();
            duck2.performFly();
            #endregion

            #region Using Decorator pattern
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.cost());
            #endregion

            // Don't close console on program end
            Console.ReadKey();
        }
    }
}
