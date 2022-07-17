using AutoMapper;
using DiplomskiRad.Middlewares;
using DocumentFormat.OpenXml.EMMA;
using DTOs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Models;
using Models.Context;
using Repositories;
using Repositories.Interfaces;
using Services;
using Services.Interfaces;
using System.Reflection;
using System.Text;
using Utils.Handlers;
using Utils.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<EntityContext>(x => x.UseNpgsql(builder.Configuration.GetConnectionString("DiplomskiDb")));

builder.Services.AddScoped<IRepositoryUser, RepositoryUser>();
builder.Services.AddScoped<IRepositoryRole, RepositoryRole>();
builder.Services.AddScoped<IRepositoryUserRole, RepositoryUserRole>();
builder.Services.AddScoped<IRepositoryTravelPlaces, RepositoryTravelPlaces>();
builder.Services.AddScoped<IRepositoryArrangment, RepositoryArrangment>();
builder.Services.AddScoped<IRepositoryArranegementGroup, RepositoryArrangementGroup>();
builder.Services.AddScoped<IRepositoryUserArrangementGroup, RepositoryUserArrangementGroup>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITravelPlacesService, TravelPlacesService>();
builder.Services.AddScoped<IArrangmentService, ArrangmentService>();
builder.Services.AddScoped<IArrangementGroupService, ArrangementGroupService>();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddSingleton<JwtTokenGenerator>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAPI", Version = "v1" });
    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new List<string>()
        }
    });
});

var profileList=new List<Profile>();
profileList.Add(new ServicesAutoMapperProfile());
profileList.Add(new UtilsMapperProfile());
profileList.Add(new AutoMapperDto());
profileList.Add(new ModelsAutoMapperProfile());

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfiles(profileList);
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);




builder.Services.AddAuthentication(obj =>
{
    obj.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    obj.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    obj.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(jwtOptions =>
    {
        jwtOptions.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler();

app.UseHttpsRedirection();

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

