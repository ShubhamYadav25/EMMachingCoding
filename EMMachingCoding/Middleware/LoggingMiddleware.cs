namespace EMMachingCoding.Middleware;

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    
    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {

        // Before next middleware
        Console.WriteLine("Before Request");

        // call next middleware
        await _next(context); // pass control to next middleware

        // After next middleware
        Console.WriteLine("After Request");

    }
}

/***
_next(context) is mandatory unless you want to stop the pipeline.
Register Middleware in Program.cs

app.UseMiddleware<LoggingMiddleware>();
 
app.MapControllers();
app.Run();
 */

/**
Short-Circuiting Middleware

public async Task InvokeAsync(HttpContext context)
{
    if (!context.Request.Headers.ContainsKey("Authorization"))
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        await context.Response.WriteAsync("Unauthorized");
        return; // pipeline stops here
    }

    await _next(context);
}

 */
