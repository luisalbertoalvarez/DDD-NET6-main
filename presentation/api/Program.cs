using api;
using AutoMapper;
using AplicationService = application.services;
using DomainService = domain.services;
using InfraestructureRepository = infraestructure.repository;
using DomainRepository = domain.contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//mapper
var mapperConfig = new MapperConfiguration(m =>
{
    m.AddProfile<MappingProfile>();
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//DDD
builder.Services.AddTransient<AplicationService.IArtistaService, AplicationService.ArtistaService>();
builder.Services.AddTransient<DomainService.IArtistaService, DomainService.ArtistaService>();
builder.Services.AddTransient<DomainRepository.IArtistaRepository, InfraestructureRepository.ArtistaRepository>();

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
