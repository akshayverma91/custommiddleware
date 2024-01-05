public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseConventionalMiddleware(this IApplicationBuilder app)
        => app.UseMiddleware<ConventionalMiddleware>();
    
    public static IApplicationBuilder UseFactoryActivatedMiddleware(this IApplicationBuilder app)
        => app.UseMiddleware<FactoryActivatedMiddleware>();

    // public static IApplicationBuilder UseFactoryActivatedMiddleware(
    // this IApplicationBuilder app, bool option)
    // {
    //     // Passing 'option' as an argument throws a NotSupportedException at runtime.
    //     return app.UseMiddleware<FactoryActivatedMiddleware>(option);
    // }
}