public class CustomMiddleware
{
    private readonly RequestDelegate _next;

    public CustomMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        // # 2
        await context.Response.WriteAsync("# 2 Start from Custom middleware.\n");
        await _next(context);
        // # 8
        await context.Response.WriteAsync("# 8 End from Custom middleware.\n");
    }
}