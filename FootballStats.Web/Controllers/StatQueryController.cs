using System.Threading.Tasks;
using FootballStats.Core;
using Microsoft.AspNetCore.Mvc;

namespace FootballStats.Web.Controllers
{
    [Route("api/stat-query")]
    public class StatQueryController : Controller
    {
        [HttpPost]
        public async Task<bool> QueryStats(StatQuery query)
        {
            return await Task.FromResult(true);
        }
    }
}
