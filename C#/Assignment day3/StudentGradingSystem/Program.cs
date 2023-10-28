namespace StudentGradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine();

            int numGrades;
            do
            {
                Console.Write("Enter the number of grades to be entered: ");
            } while (!int.TryParse(Console.ReadLine(), out numGrades) || numGrades <= 0);

            Student student = new Student(studentName, numGrades);

            for (int i = 0; i < numGrades; i++)
            {
                int grade;
                do
                {
                    Console.Write($"Enter grade {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100);

                student.Grades[i] = grade;
            }

            Console.WriteLine($"Average grade for {student.Name}: {student.CalculateAverageGrade():0.00}");
        }
    }
}