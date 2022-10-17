using ApiDevInCarGQL.Context;
using ApiDevInCarGQL.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddGraphQLServer()

    .AddQueryType<Query>();

builder.Services.AddDbContext<DevInCarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

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

// como construir repository
// porque precisa da inje��o de depend�ncia 

// ver inje��es de depend�ncias entra nesse momento? 
// partir para graphql e m�todos como listar ve�culos
