using Microsoft.AspNetCore.Mvc.Filters;

namespace EMMachingCoding.Filters;

public class AuthorizationFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Before Action");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("After Action");
    }
}
