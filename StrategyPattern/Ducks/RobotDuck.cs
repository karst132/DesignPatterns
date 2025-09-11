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
    internal class RobotDuck : Duck
    {
        public RobotDuck() : base(
            new RegularQuack(),
            new FlyWithRocket(),
            new SwimNoWay())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }
    }
}
