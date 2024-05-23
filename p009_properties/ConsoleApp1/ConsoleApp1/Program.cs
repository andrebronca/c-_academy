using System;

namespace W3S
{
    public class Person
    {
        private string name;    //campo|field|atributo|attribute

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    //automatic properties
    public class Car
    {
        public string Modelo { get; set; }

        /* se tiver só get: read-only
         * se tiver só set: write-only */
    }

    class ConsoleApp1
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Test";
            Console.WriteLine(person.Name);

            //com propriedade automatica
            Car car = new Car();
            car.Modelo = "Passeio";
            Console.WriteLine(car.Modelo);
        }
    }
}