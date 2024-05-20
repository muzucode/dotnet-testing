using HealthcareAPI.Models;
using HealthcareAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register DbContext with DI container
builder.Services.AddDbContext<HealthcareContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var persons = new[] {"Johnathan Clydesdale", "Vincent von Troth", "James Swelke"};

app.MapGet("/person", (HealthcareContext context) =>
{
    var person = new Person();
    return person;
})
.WithName("GetPerson")
.WithOpenApi();

app.MapPost("/person", (HealthcareContext context, Person person) =>
{
    context.Persons.Add(person);
    context.SaveChanges();
    return Results.Created($"/person/{person.Id}", person);
})
.WithName("PostPerson")
.WithOpenApi();

app.Run();
