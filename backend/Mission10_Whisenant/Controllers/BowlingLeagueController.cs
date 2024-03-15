using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Whisenant.Data;

namespace Mission10_Whisenant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingLeagueRepository _repo;
        public BowlingLeagueController(IBowlingLeagueRepository temp) 
        {
            _repo = temp; 
        }

        [HttpGet]
        public IEnumerable<BowlerWithTeam> GetBowlersWithTeams()
        {
            var BowlerData = _repo.GetBowlersWithTeams().ToList();

            return BowlerData;
        }

    }
}
