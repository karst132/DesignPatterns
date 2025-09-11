using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal interface IQuackBehavior
    {
        /// <summary>
        /// Fuction to try to make the duck quack
        /// </summary>
        public void Quack();
    }
}
