using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class HalfMilk : CondimentDecorator
    {
        public HalfMilk(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return 0.15 + baseBeverage!.cost();
        }
        public override string GetDescription()
        {
            return baseBeverage!.GetDescription() + ", Half Milk";
        }
    }
}
