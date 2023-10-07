using ExperimentAPI.Core;
using ExperimentAPI.DAL.Interfaces;
using ExperimentAPI.DAL.Repositories;
using ExperimentAPI.Interfaces;
using ExperimentAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IGenericRepository<ExperimentType>, ExperimentTypeRepository>(provider => new ExperimentTypeRepository(connectionString));
builder.Services.AddTransient<IGenericRepository<Experiment>, ExperimentRepository>(provider => new ExperimentRepository(connectionString));
builder.Services.AddTransient<IGenericRepository<ExperimentValue>, ExperimentValueRepository>(provider => new ExperimentValueRepository(connectionString));

builder.Services.AddTransient<IService, ExperimentService>();

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
