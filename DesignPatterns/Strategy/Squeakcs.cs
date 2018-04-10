using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class Squeakcs : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
