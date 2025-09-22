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
            doppio = new EspressoCondiment(doppio);
            PrintBeverage(doppio);

            //Lungo	Espresso	Water	
            Beverage lungo = new Espresso();
            lungo = new WaterCondiment(lungo);
            PrintBeverage(lungo);

            //Macchiato	Espresso	Milk Foam	
            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            //Corretta	Espresso	Liqour	
            Beverage corretta = new Espresso();
            corretta = new Liquor(corretta);
            PrintBeverage(corretta);

            //Con Panna	Espresso	Whip
            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            //Cappucinno	Espresso	Steamed Milk	Milk Foam	
            Beverage cappucinno = new Espresso();
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);

            //Americano	Espresso	Water	Water	
            Beverage americano = new Espresso();
            americano = new WaterCondiment(americano);
            americano = new WaterCondiment(americano);
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
            morocchino = new ChocolateCondiment(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            //Mocha	Espresso	Chocolate	Steamed Milk	Whip	
            Beverage mocha = new Espresso();
            mocha = new ChocolateCondiment(mocha);
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
            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            //Caffé affogato	Espresso	Espresso	Ice cream	
            Beverage caffeAffogato = new Espresso();
            caffeAffogato = new EspressoCondiment(caffeAffogato);
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            //Vienna coffee	Espresso	Espresso	Whip	Whip
            Beverage vienna = new Espresso();
            vienna = new EspressoCondiment(vienna);
            vienna = new Whip(vienna);
            vienna = new Whip(vienna);
            PrintBeverage(vienna);

            //Glace	Espresso	Ice cream
            Beverage glace = new Espresso();
            glace = new IceCream(glace);
            PrintBeverage(glace);

            //Chocolate milk	Chocolate	Milk	Milk
            Beverage chocolateMilk = new Chocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            //Demi – créme	Espresso	Espresso	Cream	Cream
            Beverage demiCreme = new Espresso();
            demiCreme = new EspressoCondiment(demiCreme);
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            //Latte macchiato	Espresso	Steamed Milk	Steamed Milk	Milk Foam
            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            //Freddo	Espresso	Liqour	Ice	
            Beverage freddo = new Espresso();
            freddo = new Liquor(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            //Frappuccino	Espresso	Ice	Steamed Milk	Whip
            Beverage frappuccino = new Espresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            //Caramel frappuccino	Espresso	Ice	Steamed Milk	Cream	Syrup
            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            //Frappe	Espresso	Steamed Milk	Steamed Milk	Ice cream	
            Beverage frappe = new Espresso();
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            //Irish Coffee	Espresso	Espresso	Whiskey	Whip	
            Beverage irishCoffee = new Espresso();
            irishCoffee = new EspressoCondiment(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);

            Beverage largeIrishCoffee = new Espresso(Size.Vendi);
            largeIrishCoffee = new EspressoCondiment(largeIrishCoffee);
            largeIrishCoffee = new Whiskey(largeIrishCoffee);
            largeIrishCoffee = new Whip(largeIrishCoffee);
            PrintBeverage(largeIrishCoffee);

            Beverage smallIrishCoffee = new Espresso(Size.Tall);
            smallIrishCoffee = new EspressoCondiment(smallIrishCoffee);
            smallIrishCoffee = new Whiskey(smallIrishCoffee);
            smallIrishCoffee = new Whip(smallIrishCoffee);
            PrintBeverage(smallIrishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.Cost().ToString("#.##"));
        }
    }
}