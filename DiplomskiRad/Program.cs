using Microsoft.EntityFrameworkCore;
using Models.Context;
using Repositories;
using Repositories.Interfaces;
using Services;
using Services.Handlers;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<EntityContext>(x => x.UseNpgsql(builder.Configuration.GetConnectionString("DiplomskiDb")));

builder.Services.AddScoped<IRepositoryUser, RepositoryUser>();
builder.Services.AddScoped<IRepositoryRole, RepositoryRole>();
builder.Services.AddScoped<IRepositoryUserRole, RepositoryUserRole>();

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddSingleton<JwtTokenGenerator>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

