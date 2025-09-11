using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;
using StrategyPattern.SimBehavior;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck() : base(
            new RegularQuack(), 
            new FlyWithWings(),
            new CanSwim())
        {

        }
        public override void Display()
        {
            Console.WriteLine("I'm a Readhead Duck");
        }
    }
}
