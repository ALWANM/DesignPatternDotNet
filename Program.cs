using SingletonPatternUsingStaticConstructor;
using SingletonPatternUsingStaticInitialization;
using SingletonPatternUsingStaticSingleLock;
using DesignPatterns.singleton;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestSingletonDelagateWithNoParamter(); 
            Console.ReadLine();

        }
        public static void TestSingletonDelagateWithNoParamter()
        {
            Console.WriteLine("***Singleton Pattern Demonstration");
            //SingletonStaticConstructor s = new SingletonStaticConstructor(); // error
            Console.WriteLine($"trying to get a singleton instance, called firstInstance.");
            SingletonDelagateWithNoParamter firstInstance = SingletonDelagateWithNoParamter.GetInstance;
            Console.WriteLine($"trying to get a another singleton instance, called secondInstance.");
            SingletonDelagateWithNoParamter secondInstance = SingletonDelagateWithNoParamter.GetInstance;
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The FirstInsatnce and secondInstance are the Same.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            } 
        }

        public static void TestSingletonStaticSingleLock()
        {
            Console.WriteLine("***Singleton Pattern Demonstration");
            //SingletonStaticConstructor s = new SingletonStaticConstructor(); // error
            Console.WriteLine($"trying to get a singleton instance, called firstInstance.");
            SingletonStaticSingleLock firstInstance = SingletonStaticSingleLock.GetInstance;
            Console.WriteLine($"trying to get a another singleton instance, called secondInstance.");
            SingletonStaticSingleLock secondInstance = SingletonStaticSingleLock.GetInstance;
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The FirstInsatnce and secondInstance are the Same.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.WriteLine($"the Value of MyInt {SingletonStaticSingleLock.MyInt}");
        }

        public static void TestSingletonStaticInitialisation()
        {
            Console.WriteLine("***Singleton Pattern Demonstration");
            //SingletonStaticConstructor s = new SingletonStaticConstructor(); // error
            Console.WriteLine($"trying to get a singleton instance, called firstInstance.");
            SingletonStaticInitialisation firstInstance = SingletonStaticInitialisation.GetInstance;
            Console.WriteLine($"trying to get a another singleton instance, called secondInstance.");
            SingletonStaticInitialisation secondInstance = SingletonStaticInitialisation.GetInstance;
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The FirstInsatnce and secondInstance are the Same.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.WriteLine($"the Value of MyInt {SingletonStaticInitialisation.MyInt}");
        }

        public static void TestSingletonStaticConstructor()
        {
            Console.WriteLine("***Singleton Pattern Demonstration");
            //SingletonStaticConstructor s = new SingletonStaticConstructor(); // error
            Console.WriteLine($"trying to get a singleton instance, called firstInstance.");
            SingletonStaticConstructor firstInstance = SingletonStaticConstructor.GetInstance;
            Console.WriteLine($"trying to get a another singleton instance, called secondInstance.");
            SingletonStaticConstructor secondInstance = SingletonStaticConstructor.GetInstance;
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("The FirstInsatnce and secondInstance are the Same.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.WriteLine($"the Value of MyInt {SingletonStaticConstructor.MyInt}");
        }
    }
}
