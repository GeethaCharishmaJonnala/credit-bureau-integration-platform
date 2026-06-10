using Microsoft.AspNetCore.Mvc;
using CreditBureau.API.Services;

namespace CreditBureau.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CreditReportController : ControllerBase
{
    private readonly CreditBureauService _service;

    public CreditReportController(
        CreditBureauService service)
    {
        _service = service;
    }

    [HttpGet("{customerName}")]
    public IActionResult PullCredit(string customerName)
    {
        var report =
            _service.PullCredit(customerName);

        return Ok(report);
    }
}