using System.Collections.Generic;
using System.Threading.Tasks;
using FootballStats.Core;
using Microsoft.AspNetCore.Mvc;

namespace FootballStats.Web.Controllers
{
    [Route("api/stat-query")]
    public class StatQueryController : Controller
    {
        [HttpPost]
        public async Task<StatQueryResult> QueryStats([FromBody]StatQuery query)
        {
            var queryResult = new StatQueryResult
            {
                SubjectName = query.Subject,
                Stats = new List<FootballStat>
                {
                    new PassingStat{Attempts = 1, Completions = 2, Interceptions = 3, StatGrouping = "Week 1", Touchdowns = 100}
                }
            };

            return await Task.FromResult(queryResult);
        }
    }
}
