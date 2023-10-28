namespace WebApplication2.Racerwebapi
{
    public class racer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Country { get; set; }

        public int Wins { get; set; }

        public racer() { }

        public racer(int id, string firstName, string lastName, string country, int wins)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            Wins = wins;
        }
    }
}
