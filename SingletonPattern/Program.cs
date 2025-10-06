using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread[] safeThreads = [
                new Thread(TestSingleton),
                new Thread(TestSingleton),];

            Thread[] unsafeThreads = [
                new Thread(TestSingletonThreadUnsafe),
                new Thread(TestSingletonThreadUnsafe),];

            Console.WriteLine("Testing Thread Safe Singleton:");
            
            foreach (Thread thread in safeThreads)
            {
                thread.Start();
            }

            while (safeThreads.Any(tread => tread.IsAlive))
            {
            }

            Console.WriteLine();
            Console.WriteLine("Testing Thread Unsafe Singleton:");
            foreach (Thread thread in unsafeThreads)
            {
                thread.Start();
            }

            while (unsafeThreads.Any(tread => tread.IsAlive))
            {
            }
        }

        static void TestSingleton()
        {
            ChocolateBoiler boiler = ChocolateBoiler.Instance;
            Console.WriteLine(boiler.GetHashCode());
        }

        static void TestSingletonThreadUnsafe()
        {
            ChocolateBoilerTreadUnsafe boiler = ChocolateBoilerTreadUnsafe.Instance;
            Console.WriteLine(boiler.GetHashCode());
        }
    }
}