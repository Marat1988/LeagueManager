using LeagieManager.Infrastructure;
using LeagieManager.Persentation;
using LeagieManager.Persistence;
using LeagueManager.Application;
using LeagueManager.Persentation.Controllers.Clubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddApplicationPart(typeof(ClubsController).Assembly);

builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddPersistence(builder.Configuration)
    .AddPersentation();




var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
