using Microsoft.AspNetCore.Mvc;

namespace FinancialGoalsManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        [HttpGet("/api/boxes/{boxId}/transactions")]
        public ActionResult<List<TransactionViewModel>> GetTransactionsByBox(Guid boxId) { return Ok(); }

        [HttpGet("{id}")]
        public ActionResult<TransactionViewModel> GetTransactionById(Guid id) { return Ok(); }

        [HttpPost("/api/boxes/{boxId}/transactions")]
        public IActionResult CreateTransaction(Guid boxId, [FromBody] CreateTransactionInputModel input) { return Ok(); }

        [HttpDelete("{id}")]
        public IActionResult DeleteTransaction(Guid id) { return Ok(); }
    }


}
