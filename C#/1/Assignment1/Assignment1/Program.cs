using System.Xml.Schema;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Question1
             Console.WriteLine("Enter the no of numbers to be entered");
             int a = Convert.ToInt32(Console.ReadLine());
             int[] arr = new int[a];
             for (int i = 0; i < a; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             for (int i = a - 1; i >= 0; i--)
             {
                 Console.WriteLine(arr[i]);
             }*/

            /*Question 2
            Console.WriteLine("Enter the length of the array:");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            for (int i = 0; i < b; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int c= 0;
            for (int i =0; i <b; i++)
            {
                c = c + arr[i];

            }
            Console.WriteLine(c);*/



            /*Question 3
            Console.WriteLine("Enter the length of the array:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            int[] arr_new = new int[a];
            for (int i = 0; i < a; i++)
           {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            arr_new[i] = arr[i];
            }
          for (int i = 0; i < a; i++)
          {
         Console.WriteLine(arr_new[i]);
          }*/

            //Question 4
            /* int pos;
             Console.WriteLine("Enter the size of an array");
             int n = Convert.ToInt32(Console.ReadLine());

             int[] num = new int[n];
             Console.WriteLine("Elements before deletion:");
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine($"Enter the numbers{i + 1}");
                 num[i] = Convert.ToInt32(Console.ReadLine());
             }

             Console.WriteLine("Enter the Position");
             pos = Convert.ToInt32(Console.ReadLine());
             for (int i = pos ; i < n; i++)
             {
                if( i == pos)
                 {

                 }
             }
             Console.WriteLine("Elements after deletion: ");
             for (int i = 0; i < n-1; i++)
             {
                 Console.WriteLine(num[i]);
             }*/

            // Question 5
            /*int size = 5;
            int[] arr = new int[size];
            int total = 0;
            int highestMark = int.MinValue;

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the marks of the student:" + (i + 1) + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                total += arr[i];
                if (arr[i] > highestMark)
                {
                    highestMark = arr[i];
                }

            }
            int avg = total / size;
            Console.WriteLine (" Average is : " + avg);
            Console.WriteLine("Highest mark:" +highestMark);*/






            //String
           

            // 1 Program to find occurance of specific character
           /* string sent = "Shruti chaube";
            int count = 0;
            Console.WriteLine("Enter character whose occurance you wish to see:");
            char find = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < sent.Length; i++)
            {
                if (sent[i] == find)
                {
                    count++;
                }
            }
            Console.WriteLine($"Occurance of character {find} is {count}");
            Console.WriteLine("\n");*/

            // 2 Reverse a string
           /* Console.WriteLine("Reverse a string");
            char[] charArray = sent.ToCharArray();
            var resultstring = new string(charArray.Reverse().ToArray());
            Console.WriteLine($"{resultstring}");
            Console.WriteLine("\n");*/

            // 3 Substring
            /*Console.WriteLine($"{sent.Substring(1, 6)}");
            Console.WriteLine("\n");*/

            // 4 Compare Substrings
           /* string substring1 = "sagar";
            string substring2 = "SAGAR";

            Console.WriteLine($"Comaprison considering case: {substring1 == substring2}");
            Console.WriteLine($"Comparison without considering case: {substring1.ToLower() == substring2.ToLower()}");*/

        }




        //Control structure
        //1
        /* Console.WriteLine("CheckCredit");
         Console.WriteLine("Enter your Purchase price");
         int value = Convert.ToInt32(Console.ReadLine());
         if (value > 10000)
         {
             Console.WriteLine("ERROR");
         }
         else
         {
             Console.WriteLine("Approved");
         }*/

        //2

    

Console.ReadLine();
        }
    }
}