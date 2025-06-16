using GraphQL.Models;
using GraphQL.Queries;
using GraphQL.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<UserService>();
builder.Services.AddGraphQLServer()
    .AddGraphQLServer()
    .AddQueryType<UserQuery>();

var app = builder.Build();

app.MapGraphQL();
app.Run();

