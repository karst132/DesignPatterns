using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class BlackChocolate : CondimentDecorator
    {
        public BlackChocolate(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }
        public override double cost()
        {
            return 0.40 + baseBeverage!.cost();
        }
        public override string GetDescription()
        {
            return baseBeverage!.GetDescription() + ", Black Chocolate";
        }
    }
}
