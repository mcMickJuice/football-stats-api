namespace FootballStats.Core
{
    public class PassingStat : FootballStat
    {
        public int Completions { get; set; }
        public int Attempts { get; set; }
        public int Touchdowns { get; set; }
        public int Interceptions { get; set; }
    }
}