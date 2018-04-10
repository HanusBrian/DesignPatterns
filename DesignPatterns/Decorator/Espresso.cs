using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Espresso : Beverage
    {

        public Espresso()
        {
            description = "Espresso";
            price = 1.99;
        }
        public override double cost()
        {
            return price;
        }

        public override string GetDescription()
        {
            return description;
        }
    }
}
