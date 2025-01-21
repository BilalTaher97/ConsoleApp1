using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _21_1_25_Tasks
{
    internal class Program
    {

        public class Student
        {
            private int ID;//field
            public int Id
            {
                get
                {
                    return ID;
                }
                set
                {
                    ID = value;
                }
            } //Property


            private string Name;//field
            public string name
            {
                get
                {
                    return Name;
                }

                set
                {
                    Name = value;
                }
            } //Property


            private int Age; //field
            public int age
            {
                get
                {
                   
                    return Age;
                }

                set
                {
                    if (Age < 18)
                    {
                        Age = 18;
                    }
                    else if (Age > 40)
                    {
                        Age = 40;
                    }
                    else
                    {
                        Age = value;
                    }
                }
            } //Property

            public const int MinAge = 18; //Constant
            public const int MaxAge = 40; //Constant
            public string Email { get; set; } //auto property


            public Student()
            {

            } //Empty constructor 

            public Student(int Id,string name,int age,string Email)
            {
                
                this.Id = Id;
                this.name = name;
                this.age = age;
                this.Email = Email;
            } //constructor With Parameter

            public void Print()
            {
                Console.WriteLine($"The student's name {Name} age {Age} and ID {ID}");
            } //Method

            ~Student()
            {
                Console.WriteLine("Delete All Data...");
            } //Destructor
        }
        static void Main(string[] args)
        {

            Student S1 = new Student();

            S1.name = "Ahmad";
            S1.age = 22;
            S1.Id = 1001;

            S1.Print();

            Student S2 = new Student(1002,"Bilal",27,"BilalTaher97@gmail.com");

            S2.Print();

        }
    }

    //1- A class is a template or blueprint we use it to make the code more organized
    //2- An object is an instance of the class to spacify values to the class properties
    //3- An object is an instance of the class (Part Of It)
    //4- Encapsulation, Abstract, polymorphism and inheritance
    //5- A property is a way to encabsulate the class feild so we can print or modify the feilds without a direct access to it
    //6- A feild is a normal variable declared inside a class.
    //7- A Constructor is a special method to initialize the object feilds and it will be executed automatically when we create an object
    //8- Encapsulation is one of the OOP principles and it means to hide what is supposed to be hidden and only show what is necessery
}
