using Microsoft.EntityFrameworkCore;
using RiddleSuggestions.Contexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<RiddleSuggestionsDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration[
        "ConnectionStrings:DefaultConnectionString"]);
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddControllers();

builder.Services.AddCors();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
