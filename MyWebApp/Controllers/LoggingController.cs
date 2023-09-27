using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

[ApiController]
[Route("api/logging")]
public class LoggingController : ControllerBase
{
    private readonly ILogger<LoggingController> _logger;
    private readonly IConfiguration _configuration;

    public LoggingController(ILogger<LoggingController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpPost]
    public IActionResult LogMessage([FromBody] LogMessage request)
    {
        // Get the allowed log level from configuration
        var allowedLogLevel = _configuration["Logging:AllowedLogLevel"];
        var errorLoggingEnabled = bool.Parse(_configuration["Logging:ErrorLoggingEnabled"]!);

        if (IsLogLevelAllowed(request.Level, allowedLogLevel!))
        {
            if (request.Level == "Error" && errorLoggingEnabled)
            {
                _logger.LogError(request.Message);
                return Ok(new { LogLevel = request.Level, Logged = true });
            }
            else if (request.Level == "Warning")
            {
                _logger.LogWarning(request.Message);
                return Ok(new { LogLevel = request.Level, Logged = true });
            }
            else if (request.Level == "Debug")
            {
                _logger.LogDebug(request.Message);
                return Ok(new { LogLevel = request.Level, Logged = true });
            }
        }

        return Ok(new { LogLevel = allowedLogLevel, Logged = false });
     }

    private bool IsLogLevelAllowed(string logLevel, string allowedLevel)
    {
        if (string.IsNullOrEmpty(logLevel) || string.IsNullOrEmpty(allowedLevel))
        {
            return false;
        }

        var levels = new Dictionary<string, int>
        {
            {"Debug", 0},
            {"Warning", 1},
            {"Error", 2}
        };

        return levels[allowedLevel] >= levels[logLevel];
    }
}
