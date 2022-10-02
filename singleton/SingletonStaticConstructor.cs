using System.ComponentModel.Design;
using System;
namespace SingletonPatternUsingStaticConstructor
{

    public sealed class SingletonStaticConstructor
    {
        #region  ___Singleton implementation using static constructor 
        private static readonly SingletonStaticConstructor Instance;
        private static int TotalInstances;
        public static int MyInt = 25;
        /*        
         * Private constructor is used to prevent     
         * creation of instances with the 'new' keyword
         * outside this class
         */
        private SingletonStaticConstructor()
        {
            Console.WriteLine($"-- Private constructor is called.");
            Console.WriteLine($"-- exit now from private constructor.");
        }
        /*
        * A static constructor is used for the following purposes
        *   1. To initialize any static data
        *   2. To perform a specific action only once
        * The static constructor will be called automaticlly 
        *   1. you create the first instance; or
        *   2. yo refer to any static members in your code
        */

        // here is the static constructor 
        static SingletonStaticConstructor()
        {
            Console.WriteLine($"-Static constructor is called.");
            Instance = new SingletonStaticConstructor();
            TotalInstances++;
            Console.WriteLine($"-Singleton instance is created. Number of the instance: {TotalInstances}");
            Console.WriteLine($"-- exit now from private constructor.");
        }
         public static SingletonStaticConstructor GetInstance => Instance;

        // or we can use this
        // public static SingletonStaticConstructor GetInstance
        // {
        //     get
        //     {
        //         return Instance;
        //     }
        // }
        /* The folowing line is used to diescuss the drawback of the appoach. */ 
    
        #endregion
    }
}