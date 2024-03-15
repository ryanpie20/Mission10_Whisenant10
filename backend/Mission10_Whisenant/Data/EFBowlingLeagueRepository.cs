namespace Mission10_Whisenant.Data
{
    public class EFBowlingLeagueRepository : IBowlingLeagueRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlingLeagueRepository(BowlingLeagueContext temp) 
        {
            _context = temp;
        }

        public IQueryable<Bowler> Bowlers => _context.Bowlers;
        public IQueryable<Team> Teams => _context.Teams;

        public IEnumerable<BowlerWithTeam> GetBowlersWithTeams()
        {
            var query = (from bowler in _context.Bowlers
                        join team in _context.Teams on bowler.TeamId equals team.TeamId
                        where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                        select new BowlerWithTeam
                        {
                            BowlerId = bowler.BowlerId,
                            BowlerLastName = bowler.BowlerLastName,
                            BowlerFirstName = bowler.BowlerFirstName,
                            BowlerMiddleInit = bowler.BowlerMiddleInit,
                            BowlerAddress = bowler.BowlerAddress,
                            BowlerCity = bowler.BowlerCity,
                            BowlerState = bowler.BowlerState,
                            BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                            BowlerZip = bowler.BowlerZip,
                            TeamName = team.TeamName,
                            TeamId = team.TeamId
                        }).ToList();

                        
            return query;

            
        }
    }
}
