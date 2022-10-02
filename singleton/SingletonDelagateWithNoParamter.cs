using System;

namespace DesignPatterns.singleton
{
    /*
    *Singleton implementation using Lazy <T>
    */
    public sealed class  SingletonDelagateWithNoParamter{
        // Custom delagte
        delegate SingletonDelagateWithNoParamter SingletonDelagateWithNoParamtervvcc();
        static SingletonDelagateWithNoParamter myDel = MakeSingletonInstance();

        // using built-in Func<out TResult> delegate 
        // static Func<SingletonDelagateWithNoParamter> myFuncDelegate = MakeSingletonInstance;
        private static readonly Lazy<SingletonDelagateWithNoParamter> Instance =  new Lazy<SingletonDelagateWithNoParamter>(
            // myDel()
            // myFuncDelegate()
            ()=> new SingletonDelagateWithNoParamter() //using lambda expression            
        );
        private static SingletonDelagateWithNoParamter MakeSingletonInstance()
        {
            return new SingletonDelagateWithNoParamter();
        }
        private SingletonDelagateWithNoParamter(){}
        public static SingletonDelagateWithNoParamter GetInstance{
            get{
                return Instance.Value;
            }
        }
    }
}