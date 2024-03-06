using System.Diagnostics;

namespace Web.Middleware;

public class RequestTimingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestTimingMiddleware> _logger;

    public RequestTimingMiddleware(RequestDelegate next, ILogger<RequestTimingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Stopwatch watch = Stopwatch.StartNew();
        await _next(context);
        watch.Stop();
        var executionTime = watch.ElapsedMilliseconds;
        _logger.LogInformation("Request [{Method} {Url}] executed in {ExecutionTime}ms", context.Request.Method,
            context.Request.Path, executionTime);
    }
}