 
    using System.ComponentModel.Design;
using System;
namespace SingletonPatternUsingStaticSingleLock
{

    public sealed class SingletonStaticSingleLock
    {
        #region  ___Singleton implementation using static initialization 
        /*
        * we wre using volatile to ensure that assignment to the instance varaible finishes befor it's access.
        */
        private static volatile SingletonStaticSingleLock Instance ; 
       private static Object lockObject = new Object();
        public static int MyInt = 25;
        /*        
         * Private constructor is used to prevent     
         * creation of instances with the 'new' keyword
         * outside this class
         */
        private SingletonStaticSingleLock() { }

       // public static SingletonStaticInitialisation GetInstance => Instance;

        // or we can use this
        public static SingletonStaticSingleLock GetInstance
        {
            get
            {
                // loocking it first
                lock (lockObject)
                {
                    // single check 
                    if (Instance == null)
                    {
                        Instance = new SingletonStaticSingleLock();
                    }
                }
                return Instance;
            }
        }
        /* The folowing line is used to diescuss the drawback of the appoach. */ 
    
        #endregion
    }
}

