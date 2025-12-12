namespace Practice_Linq
{
    public class FootballGame
    {
        public DateTime Date { get; set; }
        public string Home_team { get; set; }
        public string Away_team { get; set; }
        public int Home_score { get; set; }
        public int Away_score { get; set; }
        public string Tournament { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool Neutral { get; set; }
        public override string ToString()
        {
            return $"{this.Date:dd.MM.yyyy} {this.Home_team} - {this.Away_team}, Score: {this.Home_score} - {this.Away_score}, Country: {this.Country}";
        }
    }
}
