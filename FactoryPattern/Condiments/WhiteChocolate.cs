using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Beverages;
using FactoryPattern.Enums;

namespace FactoryPattern.Condiments
{
    internal class WhiteChocolate : DecoratorCondiment
    {
        public WhiteChocolate(Beverage beverage) : base(beverage) { }

		public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.Tall:
                    return 0.70 + baseBeverage.Cost();
                case BeverageSize.Grande:
                    return 1.10 + baseBeverage.Cost();
                case BeverageSize.Vendi:
                    return 1.50 + baseBeverage.Cost();
                default:
                    throw new ArgumentException("Invalid size");
			}
		}

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", White Chocolate";
        }
    }
}
