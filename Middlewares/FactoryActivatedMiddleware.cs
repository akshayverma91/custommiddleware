
class FactoryActivatedMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        // # 4
        await context.Response.WriteAsync("# 4 Start from FactoryActivatedMiddleware middleware.\n");
        await next(context);
        // # 6
        await context.Response.WriteAsync("# 6 End from FactoryActivatedMiddleware middleware.\n");
    }
}