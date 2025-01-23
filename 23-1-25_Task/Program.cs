using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_1_25_Task
{
    internal class Program
    {

        //1
        class Calculator
        {
            public void Calc(int x, int y)
            {
                Console.WriteLine(x + y);
            }

            public void Calc(int x, int y, int z)
            {
                Console.WriteLine(x + y + z);
            }

            public void Calc(double x, double y)
            {
                Console.WriteLine(x + y);
            }

        }

        //2
        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a Shape.");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Circle.");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Rectangle.");
            }
        }

        //3
        abstract class Animal
        {
            public abstract void makeSound();

            public void sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }


        }

        class Dog : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Dog barks.");
            }
        }

        class Cat : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Cat meows.");
            }
        }

        //4

        interface Playable
        {
            void Play();
        }

        class Guitar : Playable
        {
            public void Play()
            {
                Console.WriteLine("Playing the guitar.");
            }
        }

        class Piano : Playable
        {
            public void Play()
            {
                Console.WriteLine("Playing the Piano.");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
