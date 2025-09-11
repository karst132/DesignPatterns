using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.SimBehavior
{
    internal class CanSwim : ISwimBehavior
    {
        public void Swim()

        {

            Console.WriteLine("Most ducks float, even decoys!");

        }
    }
}
