using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Espresso	Espresso	
            Beverage espresso = new Espresso();
            PrintBeverage(espresso);

            //Doppio	Espresso	Espresso
            Beverage doppio = new Espresso();
            doppio = new Espresso(doppio);
            PrintBeverage(doppio);

            //Lungo	Espresso	Water	
            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            //Macchiato	Espresso	Milk Foam	
            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            //Corretta	Espresso	Liqour	
            Beverage Corretta = new Espresso();
            Corretta = new Liqour(Corretta);
            PrintBeverage(Corretta);

            //Con Panna	Espresso	Whip
            Beverage ConPanna = new Espresso();
            ConPanna = new Whip(ConPanna);
            PrintBeverage(ConPanna);

            //Cappucinno	Espresso	Steamed Milk	Milk Foam	
            Beverage cappucinno = new Espresso();
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);

            //Americano	Espresso	Water	Water	
            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            //Caffé Latte	Espresso	Steamed Milk	Steamed Milk	Milk Foam	
            Beverage caffelatte = new Espresso();
            caffelatte = new SteamedMilk(caffelatte);
            caffelatte = new SteamedMilk(caffelatte);
            caffelatte = new MilkFoam(caffelatte);
            PrintBeverage(caffelatte);

            //Flat White	Espresso	Steamed Milk	Steamed Milk	
            Beverage flatwhite = new Espresso();
            flatwhite = new SteamedMilk(flatwhite);
            flatwhite = new SteamedMilk(flatwhite);
            PrintBeverage(flatwhite);

            //Romana	Espresso	Lemon
            Beverage romana = new Espresso();
            romana = new Lemon(romana);
            PrintBeverage(romana);

            //Morocchino	Espresso	Chocolate	Milk Foam
            Beverage morocchino = new Espresso();
            morocchino = new Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            //Mocha	Espresso	Chocolate	Steamed Milk	Whip	
            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            //Bicerin	Espresso	Black Chocolate	White Chocolate	Whip
            Beverage bicerin = new Espresso();
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            //Breve	Espresso	Milk Foam	Half Milk
            Beverage breve = new Espresso();
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            //Raf coffee	Espresso	Vanilla Sugar	Cream
            Beverage rafcoffee = new Espresso();
            rafcoffee = new VanillaSugar(rafcoffee);
            rafcoffee = new Cream(rafcoffee);
            PrintBeverage(rafcoffee);

            //Mead raf	Espresso	Honey	Cream
            Beverage meadraf = new Espresso();
            meadraf = new Honey(meadraf);
            meadraf = new Cream(meadraf);
            PrintBeverage(meadraf);

            //Galao	Espresso	Milk Foam	Milk Foam	
            Beverage Galao = new Espresso();
            Galao = new MilkFoam(Galao);
            Galao = new MilkFoam(Galao);
            PrintBeverage(Galao);

            //Caffé affogato	Espresso	Espresso	Ice cream	
            Beverage caffeAffogato = new Espresso();
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            //Vienna coffee	Espresso	Espresso	Whip	Whip
            Beverage Vienna = new Espresso();
            Vienna = new Espresso(Vienna);
            Vienna = new Whip(Vienna);
            Vienna = new Whip(Vienna);
            PrintBeverage(Vienna);

            //Glace	Espresso	Ice cream
            Beverage Glace = new Espresso();
            Glace = new IceCream(Glace);
            PrintBeverage(Glace);

            //Chocolate milk	Chocolate	Milk	Milk
            Beverage ChocolateMilk = new Chocolate();
            ChocolateMilk = new Milk(ChocolateMilk);
            ChocolateMilk = new Milk(ChocolateMilk);
            PrintBeverage(ChocolateMilk);

            //Demi – créme	Espresso	Espresso	Cream	Cream
            Beverage DemiCreme = new Espresso();
            DemiCreme = new Espresso(DemiCreme);
            DemiCreme = new Cream(DemiCreme);
            DemiCreme = new Cream(DemiCreme);
            PrintBeverage(DemiCreme);

            //Latte macchiato	Espresso	Steamed Milk	Steamed Milk	Milk Foam
            Beverage LatteMacchiato = new Espresso();
            LatteMacchiato = new SteamedMilk(LatteMacchiato);
            LatteMacchiato = new SteamedMilk(LatteMacchiato);
            LatteMacchiato = new MilkFoam(LatteMacchiato);
            PrintBeverage(LatteMacchiato);

            //Freddo	Espresso	Liqour	Ice	
            Beverage Freddo = new Espresso();
            Freddo = new Liqour(Freddo);
            Freddo = new Ice(Freddo);
            PrintBeverage(Freddo);

            //Frappuccino	Espresso	Ice	Steamed Milk	Whip
            Beverage Frappuccino = new Espresso();
            Frappuccino = new Ice(Frappuccino);
            Frappuccino = new SteamedMilk(Frappuccino);
            Frappuccino = new Whip(Frappuccino);
            PrintBeverage(Frappuccino);

            //Caramel frappuccino	Espresso	Ice	Steamed Milk	Cream	Syrup
            Beverage CaramelFrappuccino = new Espresso();
            CaramelFrappuccino = new Ice(CaramelFrappuccino);
            CaramelFrappuccino = new SteamedMilk(CaramelFrappuccino);
            CaramelFrappuccino = new Cream(CaramelFrappuccino);
            CaramelFrappuccino = new Syrup(CaramelFrappuccino);
            PrintBeverage(CaramelFrappuccino);

            //Frappe	Espresso	Steamed Milk	Steamed Milk	Ice cream	
            Beverage Frappe = new Espresso();
            Frappe = new SteamedMilk(Frappe);
            Frappe = new SteamedMilk(Frappe);
            Frappe = new IceCream(Frappe);
            PrintBeverage(Frappe);

            //Irish Coffee	Espresso	Espresso	Whiskey	Whip	
            Beverage IrishCoffee = new Espresso();
            IrishCoffee = new Espresso(IrishCoffee);
            IrishCoffee = new Whiskey(IrishCoffee);
            IrishCoffee = new Whip(IrishCoffee);
            PrintBeverage(IrishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}