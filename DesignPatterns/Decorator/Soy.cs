using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
            price = .15;
            description = "Soy";
        }
    }
}
