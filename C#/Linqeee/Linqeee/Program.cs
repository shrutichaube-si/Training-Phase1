using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

namespace Linqeee
{
    internal class Program
    {
        public static void Linq1()
        {
            // int[] nos = new int[] { 1,2, 2,54, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //var res =from num in nos where num<30 orderby num select num;
            // var res=nos.Where(x=>x<30).OrderBy(x=>-x).Distinct();
            //var nos =from num in Enumerable.Range(2, 10)
            //         select new {Number=num, OddEven=num%2==0?"Even":"odd"};
            // string[] fruits = { "cherry", "plum", "apple", "peach" };
            //var res = (from f in fruits where f[0] == 'p' select f);

            string[] fruits = { "cherry", "plum", "apple", "peach" };
            string[] fruits2 = { "cherry", "plum", "apple", "peach" };
            
            
            
            foreach (var item in res)
            {
                Console.WriteLine(item+"\t");
            }
           
        }
        static void Main(string[] args)
        {
            
            Linq1();
            Console.WriteLine();
        }
    }
}