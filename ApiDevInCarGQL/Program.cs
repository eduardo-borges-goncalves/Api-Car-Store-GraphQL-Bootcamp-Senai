using ApiDevInCarGQL.Context;
using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Mutations;
using ApiDevInCarGQL.Queries;
using ApiDevInCarGQL.Repositories;
using ApiDevInCarGQL.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("TokenSettings"));
builder.Services.AddAuthorization();
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidAudience = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration.GetSection("TokenSettings").GetValue<string>("Key"))
            ),
        };
    });

builder.Services.AddDbContext<DevInCarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services
    .AddScoped<IVehicleRepository, VehicleRepository>()
    .AddScoped<ITokenService, TokenService>();

builder.Services
    .AddGraphQLServer()
    .AddAuthorization()

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

app.UseAuthentication();
app.UseAuthorization();

//app.MapGraphQL();
app.UseWebSockets()
  .UseRouting()
  .UseEndpoints(endpoint => endpoint.MapGraphQL());

app.Run();

// jwt
// subscription
// autorizações 
