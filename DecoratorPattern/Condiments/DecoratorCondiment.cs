using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal abstract class DecoratorCondiment : Beverage
    {
        protected Beverage baseBeverage;

        public abstract override double Cost();

        protected DecoratorCondiment(Beverage beverage)
        {
            baseBeverage = beverage;
            Size = beverage.Size;
        }

        public abstract override string GetDescription();

    }
}
