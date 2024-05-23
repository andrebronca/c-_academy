using System;

namespace W3S
{
    interface IAnimal
    {
        //padrão: public abstract
        void animalSound(); //não deve ter corpo
    }

    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Pig sound: wee wee");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.animalSound();
        }
    }
}