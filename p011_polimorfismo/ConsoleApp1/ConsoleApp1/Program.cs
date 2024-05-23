using System;

namespace W3S
{
    public class Animal
    {
        public string Sound { get; set; }

        /* 'virtual' permite que a classe derivada sobrescreva
         * o método da parent */
        public virtual void animalSound()
        {
            Console.WriteLine($"Animal sound: {Sound}");
        }
    }

    public class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine($"Pig sound: {Sound}");
        }
    }

    public class Dog : Animal
    {   
        public override void animalSound()
        {
            Console.WriteLine($"Dog sound: {Sound}");
        }
    }

    public class ConsoleApp1
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal p = new Pig();
            Animal d = new Dog();

            a.Sound = "zzz";
            p.Sound = "wee";
            d.Sound = "how";

            a.animalSound();
            p.animalSound();
            d.animalSound();
        }
    }
}