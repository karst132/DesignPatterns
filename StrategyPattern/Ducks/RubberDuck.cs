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
    internal class RubberDuck : Duck
    {
        public RubberDuck() : base(
            new Squeek(),
            new FlyNoWay(),
            new CanSwim())
        {

        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
