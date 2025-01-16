using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S1;

            S1 = Console.ReadLine();

            Console.WriteLine(S1);


            int x = 12;
            double y = 12.5;
            string Name = "Bilal";
            bool IsActive = false;
            char C1 = 'A';
            const int Index= 5;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Name);
            Console.WriteLine(IsActive);
            Console.WriteLine(C1);
            Console.WriteLine(Index);

            string[] Arr = { "BMW", "Opel", "Golf" };

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }


            string FName;
            string LName;
            string DateBirth;

            Console.WriteLine("Input Your First Name");
            FName = Console.ReadLine();
            Console.WriteLine("Input Your Last Name");
            LName = Console.ReadLine();
            Console.WriteLine("Input Your Date of Birth");
            DateBirth = Console.ReadLine();

            Console.Write("");













            Console.ReadKey();
        }
    }
}
