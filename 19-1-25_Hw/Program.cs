using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_25_Hw
{
    internal class Program
    {

        static double CalcKm(double x)
        {
            return x * 0.621371;
        }

        static int CalcMinutes(int hours ,int minutes )
        {
            return minutes += hours * 60; 

        }


        static void CalcTime(int minutes)
        {
            int hours = 0;
            while(minutes > 60)
            {
                hours++;
                minutes-=60;
            }

            Console.WriteLine($"{hours} Hours,{minutes} Minutes");
        }

        static int reverseNumber(int num)
        {
            int reversedNum = 0;
            while (num != 0)
            {
                int last = num % 10;
                reversedNum = (reversedNum * 10) + last;
                num /= 10;
            }
            return reversedNum;
        }
        static void Main(string[] args)
        {

            //1
            double num1 = 9.8;

            int C_num1 = Convert.ToInt32(num1);

            Console.WriteLine($"Double {num1}");
            Console.WriteLine($"Converted Int:  {C_num1}");


            //2 
            int x = 25;

            Console.WriteLine($"Your number is : {Convert.ToString(x)}");


            //3

            string Text1 = "C# is fun!";

            Console.WriteLine($"Upper: {Text1.ToUpper()}");
            Console.WriteLine($"Lower: {Text1.ToLower()}");


            //4
            string FirstName = "Bilal";
            string LastName = "Khaswneh";

            string FullName = FirstName + LastName;

            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(FullName.Length);

            //5
            int number1 = 5;
            int number2 = 9;

            if(number1 < number2)
            {
                Console.WriteLine($"Smaller Number: {number1}");
            }
            else
            {
                Console.WriteLine($"Smaller Number: {number2}");
            }

            //6
            Console.WriteLine(CalcKm(12));

            //7
            Console.WriteLine($"{CalcMinutes(2, 20)} Minutes");

            //8
            CalcTime(546);

            //9 A-
            int One = 10;
            int Two = 20;

            if(number1 > number2)
            {
                Console.WriteLine("Greater");
            }
            else
            {
                Console.WriteLine("Smaller");
            }

            //9 B-

            string Num3 = "123";
            //Num3 = Console.ReadLine();
            int Sum = 0;
            string Newnum;
            
            for (int i = 0; i < Num3.Length; i++)
            {
                Newnum = Convert.ToString(Num3[i]);

                Sum += int.Parse(Newnum);
            }

            Console.WriteLine(Sum);



            //10

           Console.WriteLine(reverseNumber(1234));

            //11

            Console.WriteLine("Enter Number 1 ?");
            int _number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 ?");
            int _number2 = Convert.ToInt32(Console.ReadLine());


            if(_number1 % _number2 == 0)
            { 
               Console.WriteLine("divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }


            //12
            Console.WriteLine("Enter Number 1 ?");
            int _num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 ?");
            int _num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 ?");
            int _num3 = Convert.ToInt32(Console.ReadLine());

            if((_num2 > _num1 && _num3 > _num2) || (_num2 < _num1 && _num3 < _num2))
            {
                Console.WriteLine($"The middle value is: {_num2}");
            }   
            else if((_num1 > _num2 && _num1 < _num3) ||(_num1 < _num2 && _num1 > _num3))
            {
                Console.WriteLine($"The middle value is: {_num1}");
            }
            else
            {
                Console.WriteLine($"The middle value is: {_num3}");
                Console.WriteLine($"The middle value is: {_num3}");
            }

        }
    }
}
