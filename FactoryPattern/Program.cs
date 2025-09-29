using FactoryPattern.Beverages;
using FactoryPattern.Condiments;
using FactoryPattern.Enums;
using FactoryPattern.Stores;

namespace FactoryPattern;

internal class Program
{
    static void Main(string[] args)
    {
        int BeverageNameCount = Enum.GetNames(typeof(BeverageName)).Length;

        Console.WriteLine("Bob's Coffee Store Orders (tall):");
        for (int i = 0; i < BeverageNameCount; i++)
        {
            BeverageStore store = new BobsCoffeeStore();
            Console.WriteLine((BeverageName)i);
            store.OrderBeverage((BeverageName)i, BeverageSize.Tall);
        }

        Console.WriteLine();
        Console.WriteLine("Starbuzz Coffee Store Orders (grande):");

        for (int i = 0; i < BeverageNameCount; i++)
        {
            BeverageStore store = new StarbuzzStore();
            Console.WriteLine((BeverageName)i);
            store.OrderBeverage((BeverageName)i, BeverageSize.Grande);
        }
    }
}