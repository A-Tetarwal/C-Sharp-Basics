using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conditionals
    {
        public Conditionals() {
            // encapsulation, inheritance, abstraction, polymorphism

        }
    }
    class Rectange
    {
        public int Area(int l, int b) {
            return l * b;
        }
        public int Boundary(int l, int b) {
            return 2*(l + b);
        }

        static void main(string[] args) { 
            Rectange rect = new Rectange();
            Console.WriteLine("Enter length");
            int length = Console.Read();
            Console.WriteLine("Enter breadth");
            int breadth = Console.Read();

            int area = rect.Area(length, breadth);
            Console.WriteLine($"Area is: {area}");

            int perimeter = rect.Boundary(length, breadth);
            Console.WriteLine($"Boundary Length: {perimeter}");

        }
    }
}
