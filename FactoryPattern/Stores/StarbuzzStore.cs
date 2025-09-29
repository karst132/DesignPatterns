using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Beverages;
using FactoryPattern.Condiments;
using FactoryPattern.Enums;

namespace FactoryPattern.Stores
{
    internal class StarbuzzStore : BeverageStore
    {
        protected override Beverage CreateBeverage(BeverageName beverageName)
        {
            switch (beverageName)
            {
                case BeverageName.Espresso:
                {
                    return new Espresso();
                }
                case BeverageName.Doppio:
                {
                    return new EspressoCondiment(
                        new Espresso());
                }
                case BeverageName.Lungo:
                {
                    return new WaterCondiment(
                        new Espresso());
                }
                case BeverageName.Macchiato:
                {
                    return new MilkFoam(
                        new Espresso());
                }
                case BeverageName.Corretta:
                {
                    return new Liquor(
                        new Espresso());
                }
                case BeverageName.ConPanna:
                {
                    return new Whip(
                        new Espresso());
                }
                case BeverageName.Cappucinno:
                {
                    return new MilkFoam(
                        new SteamedMilk(
                            new Espresso()));
                }
                case BeverageName.Americano:
                {
                    return new WaterCondiment(
                        new WaterCondiment(
                            new Espresso()));
                }
                case BeverageName.CaffeLatte:
                {
                    return new MilkFoam(
                        new SteamedMilk(
                            new SteamedMilk(
                                new Espresso())));
                }
                case BeverageName.FlatWhite:
                {
                    return new SteamedMilk(
                        new SteamedMilk(
                            new Espresso()));
                }
                case BeverageName.Romana:
                {
                    return new Lemon(
                        new Espresso());
                }
                case BeverageName.Morocchino:
                {
                    return new MilkFoam(
                        new ChocolateCondiment(
                            new Espresso()));
                }
                case BeverageName.Mocha:
                {
                    return new Whip(
                        new SteamedMilk(
                            new ChocolateCondiment(
                                new Espresso())));
                }
                case BeverageName.Bicerin:
                {
                    return new Whip(
                        new WhiteChocolate(
                            new BlackChocolate(
                                new Espresso())));
                }
                case BeverageName.Breve:
                {
                    return new HalfMilk(
                        new MilkFoam(
                            new Espresso()));
                }
                case BeverageName.RafCoffee:
                {
                    return new Cream(
                        new VanillaSugar(
                            new Espresso()));
                }
                case BeverageName.MeadRaf:
                {
                    return new Cream(
                        new Honey(
                            new Espresso()));
                }
                case BeverageName.Galao:
                {
                    return new MilkFoam(
                        new MilkFoam(
                            new Espresso()));
                }
                case BeverageName.CaffeAffogato:
                {
                    return new IceCream(
                        new EspressoCondiment(
                            new Espresso()));
                }
                case BeverageName.Vienna:
                {
                    return new Whip(
                        new Whip(
                            new EspressoCondiment(
                                new Espresso())));
                }
                case BeverageName.Glace:
                {
                    return new IceCream(
                        new Espresso());
                }
                case BeverageName.ChocolateMilk:
                {
                    return new Milk(
                        new Milk(
                            new Chocolate()));
                }
                case BeverageName.DemiCreme:
                {
                    return new Cream(
                        new Cream(
                            new EspressoCondiment(
                                new Espresso())));
                }
                case BeverageName.LatteMacchiato:
                {
                    return new MilkFoam(
                        new SteamedMilk(
                            new SteamedMilk(
                                new Espresso())));
                }
                case BeverageName.Freddo:
                {
                    return new Ice(
                        new Liquor(
                            new Espresso()));
                }
                case BeverageName.Frappuccino:
                {
                    return new Whip(
                        new SteamedMilk(
                            new Ice(
                                new Espresso())));
                }
                case BeverageName.CaramelFrappuccino:
                {
                    return new Syrup(
                        new Cream(
                            new SteamedMilk(
                                new Ice(
                                    new Espresso()))));
                }
                case BeverageName.Frappe:
                {
                    return new IceCream(
                        new SteamedMilk(
                            new SteamedMilk(
                                new Espresso())));
                }
                case BeverageName.IrishCoffee:
                {
                    return new Whip(
                        new Whiskey(
                            new EspressoCondiment(
                                new Espresso())));
                }
                default:
                {
                    throw new ArgumentException("Invalid beverage name");
                }
            }
        }
    }
}
