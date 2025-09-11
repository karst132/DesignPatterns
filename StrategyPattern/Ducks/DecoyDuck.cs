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
    internal class DecoyDuck : Duck
    {
        public DecoyDuck() : base(
            new MuteQuack(), 
            new FlyNoWay(),
            new CanSwim())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}
