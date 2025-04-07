using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register GraphQL server only in development
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddGraphQLServer()
        .AddType<ProductType>()
        .AddQueryType<Query>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // O UI é geralmente habilitado automaticamente no HotChocolate mais recente
    app.MapGraphQL(); // Maps the GraphQL endpoint
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();