using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Liquor : DecoratorCondiment
    {
        public Liquor(Beverage beverage) : base(beverage) { }

		public override double Cost()
        {
            switch (Size)
            {
                case Size.Tall:
                    return 0.60 + baseBeverage.Cost();
                case Size.Grande:
                    return 1.00 + baseBeverage.Cost();
                case Size.Vendi:
                    return 1.40 + baseBeverage.Cost();
                default:
                    throw new ArgumentException("Invalid size");
			}
		}

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Liquor";
        }
    }
}
