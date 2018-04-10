using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        Beverage beverage;
        protected CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        #region Beverage Members
        public override string GetDescription()
        {
            return string.Format("{0}, {1}", beverage.GetDescription(), description);
        }
        public override double cost()
        {
            return price + beverage.cost();
        }
        #endregion
    }
}
