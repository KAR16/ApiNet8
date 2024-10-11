using Microsoft.EntityFrameworkCore;
using ApiNet8.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string? cadena = builder.Configuration.GetConnectionString("MySQLConnection") ?? "DefaultValue";

builder.Services.AddControllers();
builder.Services.AddDbContext<Conexiones>(opt =>
    //opt.UseInMemoryDatabase("TodoList")); --> Para manejar los datos en memoria
    //opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); //-->Para manejar los datos con la cadena de conexión a Base de Datos SQL SERVER
    opt.UseMySQL(cadena)); //--> Para manejar los datos con la cadena de conexión a MySQL
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
