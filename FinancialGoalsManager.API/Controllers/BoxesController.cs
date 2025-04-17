using FinancialGoalsManager.API.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FinancialGoalsManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoxesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<BoxViewModel>> GetAllBoxes() { return Ok(); }

        [HttpGet("{id}")]
        public ActionResult<BoxViewModel> GetBoxById(Guid id) { return Ok(); }

        [HttpPost]
        public IActionResult CreateBox([FromBody] CreateBoxInputModel input) { return Ok(); }

        [HttpPut("{id}")]
        public IActionResult UpdateBox(Guid id, [FromBody] UpdateBoxInputModel input) { return Ok(); }

        [HttpDelete("{id}")]
        public IActionResult DeleteBox(Guid id) { return Ok(); }

        [HttpPost("{id}/cover")]
        public IActionResult UploadCover(Guid id, IFormFile image) { return Ok(); }

        [HttpPost("{id}/simulate-growth")]
        public ActionResult<SimulationResultViewModel> SimulateGrowth(Guid id, [FromBody] SimulateGrowthInputModel input) { return Ok(); }
    }


}
