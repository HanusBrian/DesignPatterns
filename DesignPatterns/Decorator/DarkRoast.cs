using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
            price = .99;
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
