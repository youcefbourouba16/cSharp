namespace tourement_tracker
{
    public class MatchupModel
    {
        public List<MatchupEntrieModel> Entries { get; set; }=new List<MatchupEntrieModel> ();
        public teamModel Winner { get; set; }
        public int matchRound { get; set; }

    }

    
}