using StrategyPattern.Ducks;
using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;
using StrategyPattern.SimBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new()
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck(),
                new RobotDuck()
            };

            foreach (Duck duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.PerformSwim();
                Console.WriteLine();
            }

            ducks.First(duck => duck is MallardDuck).flyBehavior = new FlyNoWay();

            ducks.First(duck => duck is RubberDuck).swimBehavior = new SwimNoWay();

            ducks.First(duck => duck is RobotDuck).quackBehavior = new Squeek();
            
            Console.WriteLine("After behavior changes:");
            Console.WriteLine();

            foreach (Duck duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.PerformSwim();
                Console.WriteLine();
            }


        }
    }
}