using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Beverages;
using FactoryPattern.Enums;

namespace FactoryPattern.Condiments
{
    internal class BobsSpecialCondiment : DecoratorCondiment
    {
        public BobsSpecialCondiment(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.Tall:
                    return 0.70 + baseBeverage.Cost();
                case BeverageSize.Grande:
                    return 0.95 + baseBeverage.Cost();
                case BeverageSize.Vendi:
                    return 1.25 + baseBeverage.Cost();
                default:
                    throw new ArgumentException("Invalid size");
            }
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Bob's special coffee";
        }
    }
}
