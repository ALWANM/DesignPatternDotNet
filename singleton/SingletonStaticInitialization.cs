using System.ComponentModel.Design;
using System;
namespace SingletonPatternUsingStaticInitialization
{

    public sealed class SingletonStaticInitialisation
    {
        #region  ___Singleton implementation using static initialization 
        private static readonly SingletonStaticInitialisation Instance = new SingletonStaticInitialisation(); 
       // private static int TotalInstances;
        public static int MyInt = 25;
        /*        
         * Private constructor is used to prevent     
         * creation of instances with the 'new' keyword
         * outside this class
         */
        private SingletonStaticInitialisation()
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
 
         public static SingletonStaticInitialisation GetInstance => Instance;

        // or we can use this
        // public static SingletonStaticInitialisation GetInstance
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