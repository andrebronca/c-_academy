using System;

namespace w3s
{
    class ConsoleApp2
    {
        public static void Main(string[] args)
        {
            string name;
            Console.WriteLine("name:");
            name = Console.ReadLine();
            Console.WriteLine("Name is: " + name);

            Console.WriteLine("age:");
            //nesse formato pode ocorrer erro caso não seja informado
            //string null não pode ser convertida para int
            //int age = Convert.ToInt32(Console.ReadLine());
            int age2 = Console.ReadLine() != null ? 
                Convert.ToInt32(Console.ReadLine()) : 0;
            //Console.WriteLine("Age is: "+ age);
            Console.WriteLine("Age is: "+ age2);

            //Math class
            Console.WriteLine("max(2,3) "+ Math.Max(2, 3));
            Console.WriteLine("min(2,3) "+ Math.Min(2, 3));
            Console.WriteLine("sqrt(64) "+ Math.Sqrt(64));
            Console.WriteLine("sqrt(65) "+ Math.Sqrt(65));
            Console.WriteLine("abs(-12.5) "+ Math.Abs(-12.5));
            Console.WriteLine("round(1.4) "+ Math.Round(1.4));
            Console.WriteLine("round(1.5) "+ Math.Round(1.5));
            Console.WriteLine("round(1.6) "+ Math.Round(1.6));
            Console.WriteLine("round(1.9) "+ Math.Round(1.9));


        }
    }
}