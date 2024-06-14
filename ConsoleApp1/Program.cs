using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // encapsulation
        class Rectange
        {
            public int Area(int l, int b)
            {
                return l * b;
            }
            public int Boundary(int l, int b)
            {
                return 2 * (l + b);
            }
        }

        // inheritance
        class Vehicle
        {
            public string brand = "ford";

            public void honk()
            {
                Console.WriteLine("tuut, tuut!");
            }
        }

        class Car : Vehicle 
        {
            public string modelName = " mustang";
        }

        // abstraction
        abstract class Animal
        {
            // abstract method (doesn't have a body)
            public abstract void animalSound();

            public void sleep()
            {
                Console.WriteLine("Zzz");
            }

        }

        class Pig: Animal
        {
            public override void animalSound() 
            { 
                Console.WriteLine("The Pig says: wee wee");
            }
        }

        class Programm
        {
            // method overloading
            public int Add(int x, int y) {
                return x + y;
            }

            public int Add(int x, int y, int z)
            {
                return x + y + z;
            }
        }


        static void Main(string[] args)
        {
            //int number = 0;
            ////                        __________________________________________________________________________
            //// data type in this lang:| int | float |  char  | Boolean | String              |   Long | Double |
            //// memory usages:         |  4 bytes    | 2bytes | 1bit    | 2byte per character |     8 bytes     |
            ////                        --------------------------------------------------------------------------
            //Console.WriteLine("Hello World, code "+number);

            //// C# em input lena
            ////Console.ReadLine(); // isko kisi variable me store bhi rwa skte hai
            ////Console.WriteLine(Console.ReadLine());


            //// ----- type casting -----

            //// 1. Implicit Casting
            //// -> char to int to long to float to double

            //// 2. Explicit Casting

            //int y = 'y'; // implicit
            //int p = (int)y; // explicit
            //Console.WriteLine(p);

            //// method which are already present for type conversion
            //// Convert.ToInt32(Console.ReadLine());
            //// Convert.ToString(Console.ReadLine());
            //// Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter name");
            //string naem = Console.ReadLine();
            //Console.WriteLine("Hello, " + naem + ", How many candies you want");
            //string candy = Console.ReadLine();
            //Console.WriteLine("hurray! you got four more candies " + (Convert.ToInt32(candy) + 4)); // idher conversion me jo bhi operation chahte ho uss poore pe ek bracket laga do


            //// ----- String methods -----
            ///*
            //.Length
            //.ToUpper()
            //.ToLower()
            //.Concat()

            //> Idhar string me js ki tarah, aise ${} values dalna bhi possible hai
            //*/

            //// syntax aise hota hai
            //Console.WriteLine("Please enter your name:");
            //string name2 = Console.ReadLine();
            //Console.WriteLine($"Your name is {name2}");

            //Console.WriteLine($"{name2[0]}");

            // ----- Area -----

            //Rectange rect = new Rectange();
            //Console.WriteLine("Enter length");
            //int length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter breadth");
            //int breadth = Convert.ToInt32(Console.ReadLine());

            //int area = rect.Area(length, breadth);
            //Console.WriteLine($"Area is: {area}");

            //int perimeter = rect.Boundary(length, breadth);
            //Console.WriteLine($"Boundary Length: {perimeter}");

            // ----- Cars ----- (inheritance)

            //Car car = new Car();
            //car.honk();
            //string model = string.Concat(car.brand, car.modelName);
            //Console.WriteLine(model);

            // ----- Animals -----

            //Pig pig1 = new Pig();
            //pig1.animalSound();
            //pig1.sleep();

            // ----- Polymorphism -----
            Programm programmi = new Programm();
            Console.WriteLine("Sum 1 is {0}", programmi.Add(2,3));
            Console.WriteLine("Sum 2 is {0}", programmi.Add(2,3,4));
        }
    }
}
