using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HierarchyofShapes
{
    internal class Ishape
    {
        interface IShape
        {
            double CalculateArea();
            double CalculatePerimeter();
        }
        class Circle : IShape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

            public double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }

            public void DisplayDetails()
            {
                Console.WriteLine("Circle Details:");
                Console.WriteLine($"Radius: {Radius}");
                Console.WriteLine($"Area: {CalculateArea()}");
                Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
            }
        }

        class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public double CalculateArea()
            {
                return Width * Height;
            }

            public double CalculatePerimeter()
            {
                return 2 * (Width + Height);
            }

            public void DisplayDetails()
            {
                Console.WriteLine("Rectangle Details:");
                Console.WriteLine($"Width: {Width}");
                Console.WriteLine($"Height: {Height}");
                Console.WriteLine($"Area: {CalculateArea()}");
                Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
            }
        }

        class Triangle : IShape
        {
            public double SideA { get; set; }
            public double SideB { get; set; }
            public double SideC { get; set; }

            public Triangle(double a, double b, double c)
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }

            public double CalculateArea()
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }

            public double CalculatePerimeter()
            {
                return SideA + SideB + SideC;
            }

            public void DisplayDetails()
            {
                Console.WriteLine("Triangle Details:");
                Console.WriteLine($"Side A: {SideA}");
                Console.WriteLine($"Side B: {SideB}");
                Console.WriteLine($"Side C: {SideC}");
                Console.WriteLine($"Area: {CalculateArea()}");
                Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
            }
        }

       
        


    }
}
