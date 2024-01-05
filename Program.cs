var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<FactoryActivatedMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
    // #1 run first
    await context.Response.WriteAsync("# 1 Start from main program.\n");
    await next.Invoke();
});

// go inside to see # rank
app.UseMiddleware<CustomMiddleware>();
// go inside to see # rank
app.UseConventionalMiddleware();
// go inside to see # rank
app.UseFactoryActivatedMiddleware();

app.Run(async context =>
{
    // # 5
    await context.Response.WriteAsync("# 5 End from main program.\n");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
