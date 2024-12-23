using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Text.Json;
using UserService;
using UserService.Data;
using UserService.GraphQL;
using UserService.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options => {
    options.Conventions.Add(new RouteTokenTransformerConvention(new SlugifyParameterTransformer()));
}).AddJsonOptions(options => {
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower; // Use snake_case
    options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.SnakeCaseLower; // Optional for dictionary keys
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddApolloFederation()
    .AddType<User>();

    
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.MapGraphQL();

app.Run();
