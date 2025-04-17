using FinancialGoalsManager.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinancialGoalsManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        [HttpGet("boxes/evolution")]
        public ActionResult<BoxesEvolutionReportViewModel> GetBoxesEvolutionReport([FromQuery] BoxesReportFilterInputModel filter) { return Ok(); }
    }
}
