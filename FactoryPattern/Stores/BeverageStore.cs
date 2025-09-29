using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Beverages;
using FactoryPattern.Enums;

namespace FactoryPattern.Stores;

internal abstract class BeverageStore
{
    public Beverage OrderBeverage(BeverageName beverageName, BeverageSize beverageSize)
    {
        Beverage beverage = CreateBeverage(beverageName);
        beverage.Size = beverageSize;
        PrintBeverage(beverage);
        return beverage;
    }

    protected abstract Beverage CreateBeverage(BeverageName beverageName);

    private void PrintBeverage(Beverage beverage)
    {
        Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost().ToString("#.##"));
    }
}
