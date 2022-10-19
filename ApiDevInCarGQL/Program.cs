using ApiDevInCarGQL.Context;
using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Mutations;
using ApiDevInCarGQL.Queries;
using ApiDevInCarGQL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DevInCarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services
    .AddScoped<IVehicleRepository, VehicleRepository>()
    .AddGraphQLServer()

    .AddQueryType()
        .AddTypeExtension<CarQuery>()

    .AddMutationType()
        .AddTypeExtension<VehicleMutation>()
        
        .AddType<Vehicle>();


// cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

app.UseCors("corsapp");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

//app.MapGraphQL();
app.UseWebSockets()
  .UseRouting()
  .UseEndpoints(endpoint => endpoint.MapGraphQL());

app.Run();

// mutations
// jwt
// subscription
// autorizações 
