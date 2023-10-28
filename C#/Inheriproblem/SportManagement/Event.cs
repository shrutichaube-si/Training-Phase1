using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportManagement
{
    internal class Event
    {
        public int EventId;
        public string EventName;
        public string EventType;
        public DateTime EventDate;
        public int regcount = 0;


        List<Athlete> Athletes= new List<Athlete>();
        Dictionary<int,int> scores = new Dictionary<int,int>();

        public int Add(string FirstName,string LastName,int age,string sport,DateTime RegDate)
        {
            Athlete athlete = new Athlete(FirstName,LastName,age,sport,RegDate);
            this.regcount++;
            athlete.AthleteId = regcount;
            Athletes.Add(athlete);
            return athlete.AthleteId;
        }

        public void DisplayDetails(int id)
        {
            foreach(var athlete in Athletes)
            {
                if(athlete.AthleteId == id)
                {
                    Console.WriteLine("Found");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }

        public void UpdateDetails(int id,string fn,string ln,int age,string sport)
        {
            foreach(var athlete in Athletes)
            {
                if( athlete.AthleteId == id)
                {
                    athlete.FirstName = fn;
                    athlete.LastName = ln;
                    athlete.Age = age;
                    athlete.Sport = sport;
                    Console.WriteLine("Details Updated");
                    return;
                }
                
            }
            Console.WriteLine("Player Not Found");
        }
        public void Remove(int id)
        {
            for(int i = 0; i < Athletes.Count; i++)
            {
                if (Athletes[i].AthleteId == id)
                {
                    Athletes.RemoveAt(i);
                    Console.WriteLine("Player Removed");
                    return;
                }
            }
            Console.WriteLine("Player not found");
        }

        public void PerfomanceTracker(int AthleteId, int score)
        {
            foreach(var athlete in Athletes)
            {
                if (athlete.AthleteId == AthleteId)
                {
                    scores.Add(AthleteId, score);
                    Console.WriteLine("PerfomanceTracked");
                    return;
                }

            }
            Console.WriteLine("Player not found");
            
        }

        

        public void ViewScore(int id)
        {
            foreach(var athlete in Athletes)
            {
                if (athlete.AthleteId == id)
                {
                    Console.WriteLine(scores[athlete.AthleteId]);
                    return;
                }
            }
            Console.WriteLine("Player not found");
        }

    }
}
