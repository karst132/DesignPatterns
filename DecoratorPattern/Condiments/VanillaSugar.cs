using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class VanillaSugar : DecoratorCondiment
    {
        public VanillaSugar(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            switch (Size)
            {
                case Size.Tall:
                    return 0.15 + baseBeverage.Cost();
                case Size.Grande:
                    return 0.25 + baseBeverage.Cost();
                case Size.Vendi:
                    return 0.35 + baseBeverage.Cost();
                default:
                    throw new ArgumentException("Invalid size");
			}
		}

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Vanilla Sugar";
        }
    }
}
