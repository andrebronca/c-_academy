using System;

namespace W3S
{
    public abstract class Animal
    {
        /* método abstrato não tem um corpo, deve ser implementado
         * pela classe derivada */
        public abstract void animalSound();

        //método regular
        public void sleep()
        {
            Console.WriteLine("zzz");
        }
    }

    //classe derivada herdando da classe abstrata
    public class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Pig sound: wee wee");
        }
    }

    public class ConsoleApp1
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.animalSound();
            pig.sleep();
        }
    }

}