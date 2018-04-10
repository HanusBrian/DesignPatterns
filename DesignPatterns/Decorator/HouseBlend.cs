using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
            price = .89;
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
