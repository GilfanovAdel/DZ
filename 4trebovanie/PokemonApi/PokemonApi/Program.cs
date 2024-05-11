using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using PokemonApi.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlPath = string.Format(@"{0}PokemonApi.xml", AppDomain.CurrentDomain.BaseDirectory);
    options.IncludeXmlComments(xmlPath);
});

  builder.Services.AddDbContext<AppDbContext>();
        

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
