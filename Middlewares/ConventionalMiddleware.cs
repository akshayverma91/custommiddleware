class ConventionalMiddleware
{
    private readonly RequestDelegate _next;
    public ConventionalMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // # 3
        await context.Response.WriteAsync("# 3 Start from ConventionalMiddleware middleware.\n");
        await _next(context);
        // # 7
        await context.Response.WriteAsync("# 7 End from ConventionalMiddleware middleware.\n");
    }
}
