using DocumentFormat.OpenXml.EMMA;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Models.Context;
using Repositories;
using Repositories.Interfaces;
using Services;
using Services.Handlers;
using Services.Interfaces;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<EntityContext>(x => x.UseNpgsql(builder.Configuration.GetConnectionString("DiplomskiDb")));

builder.Services.AddScoped<IRepositoryUser, RepositoryUser>();
builder.Services.AddScoped<IRepositoryRole, RepositoryRole>();
builder.Services.AddScoped<IRepositoryUserRole, RepositoryUserRole>();
builder.Services.AddScoped<IRepositoryTravelPlaces, RepositoryTravelPlaces>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITravelPlacesService, TravelPlacesService>();

builder.Services.AddSingleton<JwtTokenGenerator>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"Bearer {token}",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
      {
        {
          new OpenApiSecurityScheme
          {
            Reference = new OpenApiReference
              {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
              },
              Scheme = "oauth2",
              Name = "Bearer",
              In = ParameterLocation.Header,

            },
            new List<string>()
          }
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();

