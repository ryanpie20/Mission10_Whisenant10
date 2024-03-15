namespace Mission10_Whisenant.Data
{
    public interface IBowlingLeagueRepository
    {
        IQueryable<Bowler> Bowlers { get; }
        IQueryable<Team> Teams { get; }

       IEnumerable<BowlerWithTeam> GetBowlersWithTeams(); // This is a new method
    }
}
