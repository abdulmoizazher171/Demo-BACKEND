using ERP_BACKEND.dtos;
using ERP_BACKEND.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_BACKEND.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]

public class LoggerController : ControllerBase
{
    private readonly ILoggerinterface _loggerService;
    public LoggerController(ILoggerinterface loggerService)
    {
        _loggerService = loggerService;
    }


    [HttpPost("track")]
    public async Task<IActionResult> LogActivity([FromBody] LogEntry entry)
    {
        var userAgent = Request.Headers["User-Agent"].ToString();
        await _loggerService.SavelogAsync(entry, userAgent);
        return Ok();
    }

}