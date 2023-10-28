using System.Security.Cryptography.X509Certificates;

namespace SportManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event ipl = new Event();
            ipl.EventName = "ipl";
            ipl.EventId = 1;
            ipl.EventType = "Cricket";
            ipl.EventDate = new DateTime(2023,10,14);

            ipl.Add("Shruti", "Chaube", 20, "Cricket", new DateTime(2023, 4, 23));
            ipl.Add("Aditya", "pandey", 21, "football", new DateTime(2023, 4, 23));

            ipl.DisplayDetails(2);
            ipl.DisplayDetails(3);
            ipl.UpdateDetails(1, "shruti", "pandey", 20, "Cricker");
            ipl.UpdateDetails(3, "shruti", "pandey", 20, "Cricker");
            ipl.PerfomanceTracker(1, 200);
            ipl.ViewScore(1);
            ipl.PerfomanceTracker(4, 500);



        }
    }
}