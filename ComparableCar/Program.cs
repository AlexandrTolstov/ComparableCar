using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 80, 234);
            myAutos[2] = new Car("Viper", 80, 34);
            myAutos[3] = new Car("Mel", 80, 4);
            myAutos[4] = new Car("Chucky", 80, 5);

            Console.WriteLine("Here is the unordered set of cars:");
            foreach (var c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            }
            Array.Sort(myAutos);
            Console.WriteLine();

            Console.WriteLine("Here is the ordered set of cars:");
            foreach(Car c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            }

            Array.Sort(myAutos, Car.SortByPetName);
            Console.WriteLine("Ordering by pet name:");
            foreach (Car c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            }
            Console.ReadLine();
        }
    }
}
