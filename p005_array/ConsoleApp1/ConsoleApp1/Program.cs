using System;
using System.Linq;  //funções Min, Max, Sum

namespace W3S
{
    public class ConsoleApp1
    {
        public static void Main(string[] args)
        {
            //declarando um array, nesse caso, se a inicialização ocorrer depois
            //deve-se utilizar o operador new.
            string[] cars;

            //adicionando valores posteriormente
            cars = new string[] { "Gol", "Vectra", "Uno com escada" };

            //modos de criação de array
            string[] frutas = new string[4];

            //criando um array com 4 elementos
            string[] frutas2 = new string[4] { "maçã", "banana", "uva", "abacate" };

            //criando um array sem especificar o tamanho
            string[] frutas3 = new string[] { "maçã", "banana", "uva", "abacate" };

            //declarando e atribuindo, omitindo o new e o tamanho
            string[] cars2 = { "Volvo", "BMW", "Ford" };

            //declarando um array de números inteiros
            int[] numeros = { 1, 2, 3 };

            //acessando o primeiro elemento
            Console.WriteLine($"1ª marca: {cars2[0]}");

            //mudando um elemento
            cars2[0] = "Chevrolet";
            Console.WriteLine($"1ª marca: {cars2[0]}");

            //tamanho do array
            Console.WriteLine($"tamanho da lista de marcas: {cars2.Length}");

            //percorrendo um array: for tradicional
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"carro: {cars[i]}");
            }

            //percorrendo um array: foreach
            foreach (string f in frutas2)
            {
                Console.WriteLine($"fruta: {f}");
            }

            //ordenando um array alfabeticamente:
            Array.Sort(frutas2);
            //percorrendo um array: foreach
            foreach (string f in frutas2)
            {
                Console.WriteLine($"fruta: {f}");
            }

            int[] n2 = { 7, 3, 4, 1, 8 };
            Console.WriteLine(n2);
            //ordenar um array numérico
            Array.Sort(n2);
            foreach (int n in n2)
            {
                Console.WriteLine($"n: {n}");
            }

            //usando funções do System.Linq
            Console.WriteLine($"Min: {n2.Min()}");
            Console.WriteLine($"Max: {n2.Max()}");
            Console.WriteLine($"Sum: {n2.Sum()}");
            Console.WriteLine($"Average: {n2.Average()}");
        }
    }
}
