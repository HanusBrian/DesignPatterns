using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class Beverage
    {
        protected string description;
        protected double price;
        public abstract string GetDescription();

        public abstract double cost();
    }
}
