using Microsoft.EntityFrameworkCore;
using RiddleSuggestions.Contexts;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<RiddleSuggestionsDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration[
        "ConnectionStrings:DefaultConnectionString"]);
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddControllers();

app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
