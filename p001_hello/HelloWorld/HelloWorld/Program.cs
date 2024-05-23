using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14D;
            string msg = "testes no console";
            //int 32
            int x, y, z;
            x = y = z = 0;
            char continua = 'S';
            bool clicou = false;
            float desconto = 1.2F;
            double valor = 9.99D;
            //int 64
            long peso = 999988888777L;
            //números científicos: float, double
            float cientifico = 12e3F;
            double cientifico2 = 12e10D;

            Console.WriteLine("teste: "+ msg);
            Console.WriteLine(pi);
            Console.WriteLine(x + y + z);

            //cast implicit
            //char->int->long->float->double
            int t = continua;
            Console.WriteLine(continua + 1);
            Console.WriteLine(t);
            float t2 = t; 
            Console.WriteLine(t2);

            //cast explicit
            //double->float->long->int->char
            int t3 = (int)valor;
            Console.WriteLine(valor);
            Console.WriteLine(t3);
            Console.WriteLine(Convert.ToString(t3));
            Console.WriteLine(Convert.ToInt32(valor));
            Console.WriteLine(Convert.ToInt64(t3));
        }
    }
}