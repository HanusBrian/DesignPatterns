using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Mocha : CondimentDecorator
    {

        public Mocha(Beverage beverage) : base(beverage)
        {
            this.price = .20;
            this.description = "Mocha";
        }
    }
}
