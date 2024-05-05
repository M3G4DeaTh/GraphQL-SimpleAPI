using FuelManagerGraphQL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("FuelManagerDB"));

builder.Services
    .AddGraphQLServer()
    .AddMutationType<Mutation>()
    .AddQueryType<Query>()
    .AddProjections().AddFiltering().AddSorting();

var app = builder.Build();

app.MapGraphQL("/");

app.Run();