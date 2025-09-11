using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        public IQuackBehavior quackBehavior { private get; set; }

        public IFlyBehavior flyBehavior { private get; set; }

        public ISwimBehavior swimBehavior { private get; set; }

        public Duck(
            IQuackBehavior quackBehavior,
            IFlyBehavior flyBehavior,
            ISwimBehavior swimBehavior)
        {
            this.quackBehavior = quackBehavior;
            this.flyBehavior = flyBehavior;
            this.swimBehavior = swimBehavior;
        }       

        public abstract void Display();

        public void PerformQuack()

        {

            quackBehavior.Quack();

        }

        public void PerformFly()

        {

            flyBehavior.Fly();

        }

        public void PerformSwim()

        {

            swimBehavior.Swim();

        }

    }
}
