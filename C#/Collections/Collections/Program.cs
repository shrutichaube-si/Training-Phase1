using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            // list.Add("shruti");
            // list.Add("shruti");
            // list.Add("shruti");
            // list.Add(34);
            // list.Add(new int[3]);
            // foreach(Object item in list)
            // {
            //     Console.WriteLine(item);
            // }
            // List<int> list = new List<int>();
            // list.Add(1);
            // list.Add(2);
            //// list.Add("shruti");
            // foreach (Object i in list)
            // {
            //     Console.WriteLine(i);
            // }
            //List <double>list = new List<double> ();
            // list.Add (1.0);
            // list.Add (2.6554);
            // foreach (double d in list)
            // {
            //     Console.WriteLine (d);
            // }

            List<String> l = new List<String>() { "shruti", "shara", "aaditya", "shounak", "", "", "shounak", "shounak" };
            Console.WriteLine(l.Capacity);
            Console.WriteLine(l.Count);
            Console.WriteLine(l.IndexOf("shruti"));

            //HashSet <int> h1 = new HashSet<int>() { 1,2,3,4};

            //h1.Add (1);
            //h1.Add (2);
            //h1.Add (2);
            //Console.WriteLine (h1.IndexOf(2);
            //h1.Remove (1);
            //foreach(int i in h1)
            //{
            //    Console.WriteLine (i);
        }




        }
    }
