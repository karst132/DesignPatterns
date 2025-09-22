using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class EspressoCondiment : DecoratorCondiment
    {
        public EspressoCondiment(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            switch (Size)
            {
                case Size.Tall:
                    return 0.50 + baseBeverage.Cost();
                case Size.Grande:
                    return 0.80 + baseBeverage.Cost();
                case Size.Vendi:
                    return 1.10 + baseBeverage.Cost();
                default:
                    throw new ArgumentException("Invalid size");
            }
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Espresso";
        }
    }
}
