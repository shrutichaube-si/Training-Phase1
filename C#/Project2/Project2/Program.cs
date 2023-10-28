namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //nsole.WriteLine("Hello, World!");
                /*onsole.Write("new vehicle regsistered");
                 int num = Convert.ToInt32(Console.ReadLine());
                 int[] list = new int[num];
                 for(int i = 0; i < num; i++)
                 {
                     Console.WriteLine("Enter vehicle no");
                     list[i]= Convert.ToInt32(Console.ReadLine());
                 }
                 foreach(i in list)
                 {
                     Console.WriteLine("entries" + i);
                 }*/
                {
                    Console.Write("Enter the number of students: ");
                    int numStudents = Convert.ToInt32(Console.ReadLine());

                    string[] studentNames = new string[numStudents];
                    int[] studentScores = new int[numStudents];


                    for (int i = 0; i < numStudents; i++)
                    {

                        studentNames[i] = Console.ReadLine();

                        studentScores[i] = Convert.ToInt32(Console.ReadLine()); ;
                    }
                    for (int i = 0; i < numStudents; i++)
                    {
                        Console.WriteLine(studentNames[i]);
                        Console.WriteLine(GetLetterGrade(studentScores[i]));
                    }
                    Console.ReadLine();

                    static string GetLetterGrade(int score)
                    {
                        if (score >= 90)
                            return "AI";
                        else if (score >= 80)
                            return "IT";
                        else if (score >= 70)
                            return "EEE";
                        else if (score >= 60)
                            return "Maths";
                        else
                            return "F";
                    }



                }
            }
        }
    }
}