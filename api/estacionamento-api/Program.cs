using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using estacionamento_api.Contexts;
using estacionamento_api.Services.Auth;
using estacionamento_api.Services.Carro;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("PostgresConnectionString");

//CONTEXTOS
builder.Services.AddDbContext<CarroContext>(options => options.UseNpgsql(connectionString));
builder.Services.AddDbContext<AuthContext>(options => options.UseNpgsql(connectionString));
//CONTEXTOS

//SERVIÇOS
builder.Services.AddScoped<ICarroService, CarroService>();
builder.Services.AddScoped<IAuthService, AuthService>();
//SERVIÇOS 

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();