namespace Delegates
{
    delegate int Calculate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
           
           calci c = new calci();  
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            Calculate cal= null;
            char op = Convert.ToChar(Console.ReadLine());
            switch(op)
            {
                case '+':
                   cal= c.Add;
    
                    break;
                case '-':
                    cal=c.sub;
                    break;
                case '*':
                    cal =c.multi;
    
                    break;
                case '/':
                    cal = c.divide;
         
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;

            }
            display( num2, num1, cal);

           
        }

        public static void display(int a, int b,Calculate del) 
        {
            int y = del(a, b);
            Console.WriteLine(y);
        }
        
    }
}