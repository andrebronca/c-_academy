using System;

namespace W3S
{
    public class ConsoleApp1
    {

        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.ligado = true;
            c1.modelo = "Passeio";
            c1.color = "red";
            c1.anoFabricacao = 2010;

            Console.WriteLine("Carro: c1");
            Console.WriteLine(c1.modelo);
            Console.WriteLine(c1.color);
            Console.WriteLine(c1.estaLigado());
            Console.WriteLine(c1.anoFabricacao);
            
            //usando parâmetro nomeado do construtor
            Car c2 = new Car(ligado: false);
            c2.modelo = "Utilitário";
            c2.color = "blue";
            c2.anoFabricacao = 2020;

            Console.WriteLine("Carro: c2");
            Console.WriteLine(c2.modelo);
            Console.WriteLine(c2.color);
            Console.WriteLine(c2.estaLigado());
            Console.WriteLine(c2.anoFabricacao);

            //usando construtor para inicializar todos os atributos
            Car c3 = new Car("gray", 2022, true, "Coletivo");
            Console.WriteLine("Carro: c3");
            Console.WriteLine(c3.modelo);
            Console.WriteLine(c3.color);
            Console.WriteLine(c3.estaLigado());
            Console.WriteLine(c3.anoFabricacao);
        }
    }


}