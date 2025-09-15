using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class MilkFoam : CondimentDecorator
    {
        public MilkFoam(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return 0.25 + baseBeverage?.cost() ?? 0;
        }

        public override string GetDescription()
        {
            return baseBeverage?.GetDescription() + ", MilkFoam";
        }
    }
}
