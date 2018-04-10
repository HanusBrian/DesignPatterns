using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class Duck
    {
        IQuackBehavior quackBehavior;
        IFlyBehavior flyBehavior;

        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void setQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
        public void setFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }
    }
}
