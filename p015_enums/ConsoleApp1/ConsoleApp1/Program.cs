using System;

namespace W3S
{
    /* enum são como constantes, há conhecimento no desenvolvimento
     * de valores que não sofrerão alterações, caso haja alteração
     * irá ocorrer em um único ponto.
     * Exemplo de usos: dias, meses, cores */
    public enum Level
    {
        Low,    // 0 (valor automático)
        Medium, // 1
        High    // 2
    }

    public class Util
    {
        public enum Escala
        {
            Baixo, Medio, Alto
        }
    }

    enum Meses
    {
        Janeiro,    // 1 (valor for forçado)
        Fevereiro,
        Marco = 3,  //força a atualização dos outros valores
        Abril,
        Maio        // 5
    }



    class Program
    {
        static void Main(string[] args)
        {
            Level nivel = Level.Medium;
            Console.WriteLine(nivel);
            Console.WriteLine((int) nivel);
            

            Util.Escala escalaM = Util.Escala.Medio;

            //casting do value para fazer comparação
            if ((int) escalaM == (int) nivel)
            {
                Console.WriteLine("Escalas iguais");
            } else
            {
                Console.WriteLine("Escalas diferentes");
            }

            //Enum em um switch
            switch (nivel)
            {
                case Level.Low:
                    Console.WriteLine("Baixo");
                    break;
                case Level.Medium:
                    Console.WriteLine("Médio");
                    break;
                case Level.High:
                    Console.WriteLine("Alto");
                    break;
            }
            
        }
    }
}