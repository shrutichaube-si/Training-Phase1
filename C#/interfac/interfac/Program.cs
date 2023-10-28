namespace interfac
{
     public  interface Polygon
    {
        void calculateArea(int l, int b);
    }
    class Rectangle : Polygon
    {
        public void calculateArea(int l, int b)
        {

            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Rectangle r = new Rectangle();
            r.calculateArea(344, 67);  
        }
    }
}