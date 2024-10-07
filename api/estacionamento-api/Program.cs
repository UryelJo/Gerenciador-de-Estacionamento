using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using Projeto_Estacionamento.Contexts;
using Projeto_Estacionamento.Services;
using Projeto_Estacionamento.Services.Carro;
using Projeto_Estacionamento.Services.Guarda;
using Projeto_Estacionamento.Services.Motorista;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("PostgresConnectionString");

//SERVIÇOS ================================================================|




builder.Services.AddDbContext<CarroContext>(options =>
    options.UseNpgsql(connectionString));
builder.Services.AddDbContext<PessoaContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<ICarroService, CarroService>();
builder.Services.AddScoped<IMotoristaService, MotoristaService>();
builder.Services.AddScoped<IGuardaService, GuardaService>();





//SERVIÇOS ================================================================|

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