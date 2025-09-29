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
    internal class BobsCoffeeStore : BeverageStore
    {
        protected override Beverage CreateBeverage(BeverageName beverageName)
        {
            switch (beverageName)
            {
                case BeverageName.Espresso:
                {
                    return new BobsSpecial();
                }
                case BeverageName.Doppio:
                {
                    return new BobsSpecialCondiment(
                        new BobsSpecial());
                }
                case BeverageName.Lungo:
                {
                    return new WaterCondiment(
                        new BobsSpecial());
                }
                case BeverageName.Macchiato:
                {
                    return new MilkFoam(
                        new BobsSpecial());
                }
                case BeverageName.Corretta:
                {
                    return new Liquor(
                        new BobsSpecial());
                }
                case BeverageName.ConPanna:
                {
                    return new Whip(
                        new BobsSpecial());
                }
                case BeverageName.Cappucinno:
                {
                    return new MilkFoam(
                        new SteamedMilk(
                            new BobsSpecial()));
                }
                case BeverageName.Americano:
                {
                    return new WaterCondiment(
                        new WaterCondiment(
                            new BobsSpecial()));
                }
                case BeverageName.CaffeLatte:
                {
                    return new MilkFoam(
                        new SteamedMilk(
                            new SteamedMilk(
                                new BobsSpecial())));
                }
                case BeverageName.FlatWhite:
                {
                    return new SteamedMilk(
                        new SteamedMilk(
                            new BobsSpecial()));
                }
                case BeverageName.Romana:
                {
                    return new Lemon(
                        new BobsSpecial());
                }
                case BeverageName.Morocchino:
                {
                    return new MilkFoam(
                        new ChocolateCondiment(
                            new BobsSpecial()));
                }
                case BeverageName.Mocha:
                {
                    return new Whip(
                        new SteamedMilk(
                            new ChocolateCondiment(
                                new BobsSpecial())));
                }
                case BeverageName.Bicerin:
                {
                    return new Whip(
                        new WhiteChocolate(
                            new BlackChocolate(
                                new BobsSpecial())));
                }
                case BeverageName.Breve:
                {
                    return new HalfMilk(
                        new MilkFoam(
                            new BobsSpecial()));
                }
                case BeverageName.RafCoffee:
                {
                    return new Cream(
                        new VanillaSugar(
                            new BobsSpecial()));
                }
                case BeverageName.MeadRaf:
                {
                    return new Cream(
                        new Honey(
                            new BobsSpecial()));
                }
                case BeverageName.Galao:
                {
                    return new MilkFoam(
                        new MilkFoam(
                            new BobsSpecial()));
                }
                case BeverageName.CaffeAffogato:
                {
                    return new IceCream(
                        new BobsSpecialCondiment(
                            new BobsSpecial()));
                }
                case BeverageName.Vienna:
                {
                    return new Whip(
                        new Whip(
                            new BobsSpecialCondiment(
                                new BobsSpecial())));
                }
                case BeverageName.Glace:
                {
                    return new IceCream(
                        new BobsSpecial());
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
                            new BobsSpecialCondiment(
                                new BobsSpecial())));
                }
                case BeverageName.LatteMacchiato:
                {
                    return new MilkFoam(
                        new SteamedMilk(
                            new SteamedMilk(
                                new BobsSpecial())));
                }
                case BeverageName.Freddo:
                {
                    return new Ice(
                        new Liquor(
                            new BobsSpecial()));
                }
                case BeverageName.Frappuccino:
                {
                    return new Whip(
                        new SteamedMilk(
                            new Ice(
                                new BobsSpecial())));
                }
                case BeverageName.CaramelFrappuccino:
                {
                    return new Syrup(
                        new Cream(
                            new SteamedMilk(
                                new Ice(
                                    new BobsSpecial()))));
                }
                case BeverageName.Frappe:
                {
                    return new IceCream(
                        new SteamedMilk(
                            new SteamedMilk(
                                new BobsSpecial())));
                }
                case BeverageName.IrishCoffee:
                {
                    return new Whip(
                        new Whiskey(
                            new BobsSpecialCondiment(
                                new BobsSpecial())));
                }
                default:
                {
                    throw new ArgumentException("Invalid beverage name");
                }
            }
        }
    }
}
