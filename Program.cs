using Microsoft.EntityFrameworkCore;
using RiddleSuggestions.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RiddleSuggestionsDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration[
        "ConnectionStrings:DefaultConnectionString"]);
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddCors( opt =>
{
    opt.AddPolicy("AllowAnyOrigin", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.UseCors("AllowAnyOrigin");

app.MapGet("/", () => "Hello World!");

app.Run();
