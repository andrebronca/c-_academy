using System;

namespace W3S
{
    public class ConsoleApp1
    {
        public static void Main(string[] args)
        {
            //criando um array 2D
            int[,] numeros = { { 1, 4, 3 }, { 2, 5, 6 } };

            //um array com 3 dimensoes deve ser: [,,]

            //segunda linha, segundo objeto: 5
            Console.WriteLine(numeros[1,1]);

            Console.WriteLine(numeros[0, 1]);
            //mudando um elemento
            numeros[0, 1] = 10;
            Console.WriteLine(numeros[0,1]);

            //percorrendo um array 2D
            foreach(int a in numeros)
            {
                Console.WriteLine($"> {a}");
            }

            //percorrendo com for tradicional
            //deve-se utilizar: GetLength
            for(int i = 0; i < numeros.GetLength(0); i++)
            {
                for(int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i},{j}] = {numeros[i,j]}");
                }
            }
        }
    }
}