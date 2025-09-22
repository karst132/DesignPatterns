using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Whip : DecoratorCondiment
    {
        public Whip(Beverage beverage) : base(beverage) { }

		public override double Cost()
        {
            switch (Size)
            {
                case Size.Tall:
                    return 0.30 + baseBeverage.Cost();
                case Size.Grande:
                    return 0.50 + baseBeverage.Cost();
                case Size.Vendi:
                    return 0.70 + baseBeverage.Cost();
                default:
                    throw new ArgumentException("Invalid size");
			}
		}

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Whip";
        }
    }
}
