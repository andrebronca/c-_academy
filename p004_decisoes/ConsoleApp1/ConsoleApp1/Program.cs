using System;

namespace W3S
{
    public class ConsoleApp1
    {
        public static void Main(string[] args)
        {
            //********* estrutura de seleção

            //if - else
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("boa tarde");
            }
            else
            {
                Console.WriteLine("boa noite");
            }

            //usando operdor ternário
            string saudacao = (time < 18) ? "boa tarde" : "boa noite";
            Console.WriteLine(saudacao);

            //if - else if - else
            if (time < 10)
            {
                Console.WriteLine("bom dia");
            }
            else if (time < 20)
            {
                Console.WriteLine("boa tarde");
            }
            else
            {
                Console.WriteLine("boa noite");
            }

            int dia = 4;


            //switch
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                //demonstrar a estrutura
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                default:
                    Console.WriteLine("final de semana");
                    break;
            }

            //********* estrutura de repetição

            //while
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"> {i}");
                i++;
            }

            //do - while
            int j = 0;
            do
            {
                Console.WriteLine($"-> {j++}");
            } while (j < 5);

            for(int k = 0; k < 5; k++)
            {
                Console.WriteLine($": {k}");
            }

            //************* foreach
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string c in cars)
            {
                Console.WriteLine($"=> {c}"); 
            }

            //saltar fora de um loop: break
            for(int w = 0; w < 7; w++)
            {
                if (w == 4)
                {
                    break;
                }
                Console.WriteLine($"..: {w}");
            }

            //pular determinada iteração: continue
            for(int z = 1; z <= 8; z++)
            {
                if (z == 4)
                {
                    continue;
                }
                Console.WriteLine($"-: {z}");
            }
        
        }
    }
}