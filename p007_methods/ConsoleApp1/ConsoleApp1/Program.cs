using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace W3S
{
    public class ConsoleApp1
    {
        public static void Main(string[] args)
        {
            //métodos void
            msg("teste");
            msg2("enviando argumento");

            //polimorfismo
            //métodos com return
            //enviando argumentos para os métodos
            msg(Convert.ToString(vezesDez(5)));
            msg(soma(3, 7));

            //exemplo sem named arguments
            fullName("André", "Bronca");

            //exemplo com named arguments
            fullName(lname: "Bronca", fname: "André");
        }

        //só executa com instanciação, é um método do objeto
        public void Log(string msg) 
        {
            Console.WriteLine(msg); 
        }

        //executa sem instanciação, é um método da classe
        static void msg(string msg)
        {
            Console.WriteLine(msg);
        }

        //overloadin do método: msg(string msg)
        static void msg(int m)
        {
            Console.WriteLine(Convert.ToString(m)); 
        }

        //parâmetro com valor padrão, parâmetro opcional
        static void msg2(string msg = "")
        {
            Console.WriteLine(msg + ".");
        }

        //retornando valor
        static int vezesDez(int x)
        {
            return x * 10;
        }

        static int soma(int x, int y)
        {
            return x + y;
        }

        //overloading do soma
        static double soma(double x, double y)
        {
            return x + y;
        }

        //criando um método para exibir o funcionamento de: named arguments
        static void fullName(string fname ,string lname)
        {
            Console.WriteLine($"{fname} {lname}");
        }
    }
}