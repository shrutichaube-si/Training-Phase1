using System.Drawing;

namespace HierarchyofShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Triangle triangle = new Triangle(3, 4, 5);

            circle.DisplayDetails();
            Console.WriteLine();

            rectangle.DisplayDetails();
            Console.WriteLine();

            triangle.DisplayDetails();
        }
    }
}