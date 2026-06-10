using Microsoft.AspNetCore.Mvc;

namespace CreditBureau.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DealerController : ControllerBase
{
    [HttpGet("validate/{dealerCode}")]
    public IActionResult ValidateDealer(
        string dealerCode)
    {
        return Ok(new
        {
            DealerCode = dealerCode,
            IsValid = true,
            DealerStatus = "Active"
        });
    }
}