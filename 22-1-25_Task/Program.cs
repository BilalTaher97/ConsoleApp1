using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_25_Task
{
    internal class Program
    {
        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }

            public void Print()
            {
                Console.WriteLine("Vehicle is starting.");
            }
        }

        class Car : Vehicle
        {
            public int NumberofDoor { get; set; }
        }
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Brand = "BMW";
            car1.Model = "2020";
            car1.NumberofDoor = 4;

            car1.Print();



        }
    }
}
