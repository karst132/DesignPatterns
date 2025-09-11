using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.QuackBehavior
{
    internal class MuteQuack : IQuackBehavior
    {
        /// <inheritdoc/>
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
