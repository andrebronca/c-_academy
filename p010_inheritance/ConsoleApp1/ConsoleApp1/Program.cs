using System;

namespace W3S 
{
    /* Para bloquear a herança de uma classe, 
     * usa-se a keyword: 'sealed' antes de 'class'.
     ex.: sealed class Vehicle */
    public class Vehicle    //base class (parent)
    {
        public string Brand { get; set; }

        public void honk()
        {
            Console.WriteLine("arrrr");
        }
    }

    public class  Car : Vehicle //derived class (child)
    {
        public string ModelName { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.honk(); //método herdado
            car.Brand = "Ford"; //atributo herdado
            car.ModelName = "Ranger";
            Console.WriteLine(car.Brand +" "+ car.ModelName);
        }
    }

}