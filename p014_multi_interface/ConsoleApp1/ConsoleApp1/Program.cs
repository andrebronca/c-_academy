using System;

namespace W3S
{
    interface IFirstInterface
    {
        void myMethod();
    }

    interface ISecondInterface
    {
        void myOtherMethod();
    }

    //implementando múltiplas interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Algo ...");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Outro ...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass dm = new DemoClass();
            dm.myMethod();
            dm.myOtherMethod();
        }
    }
}