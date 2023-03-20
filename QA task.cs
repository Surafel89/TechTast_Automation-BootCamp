using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yes = "y";
            while (yes == "y" || yes == "Y")
            {
                // Input coordinates of 3 points
                Console.WriteLine("Enter coordinates of point 1:");
                Console.Write("Enter x: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("Enter y: ");
                double y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter coordinates of point 2:");
                Console.Write("Enter x: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("Enter y: ");
                double y2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter coordinates of point 3:");
                Console.Write("Enter x: ");
                double x3 = double.Parse(Console.ReadLine());
                Console.Write("Enter y: ");
                double y3 = double.Parse(Console.ReadLine());

                // Calculate lengths of sides
                double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

                // Output lengths of sides
                Console.WriteLine("Length of side a: " + a);
                Console.WriteLine("Length of side b: " + b);
                Console.WriteLine("Length of side c: " + c);

                // Check if equilateral triangle
                bool isEquilateral = a == b && b == c;
                Console.WriteLine("Is it an equilateral triangle? " + isEquilateral);

                // Check if isosceles triangle
                bool isIsosceles = a == b || b == c || c == a;
                Console.WriteLine("Is it an isosceles triangle? " + isIsosceles);

                // Check if right triangle
                bool isRight = Math.Abs(Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) < 0.0001 ||
                               Math.Abs(Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) < 0.0001 ||
                               Math.Abs(Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) < 0.0001;
                Console.WriteLine("Is it a right triangle? " + isRight);

                // Calculate perimeter
                double perimeter = a + b + c;
                Console.WriteLine("Perimeter of triangle: " + perimeter);

                // Output even numbers up to perimeter
                Console.WriteLine("Even numbers up to perimeter:");
                for (int i = 0; i <= perimeter; i += 2)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("If you want to continue, type y or Y and press enter");
                Console.WriteLine("If you don't want to continue, type anything else end press enter");
                yes = Console.ReadLine();
            }
        }
    }
}
