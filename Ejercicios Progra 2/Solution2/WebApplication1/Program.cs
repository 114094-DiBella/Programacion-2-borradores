using ClassLibrary1.Data;
using ClassLibrary1.Data.Dao.Implementacion;
using ClassLibrary1.Data.Dao.Interface;
using ClassLibrary1.Negocio.Implementacion;
using ClassLibrary1.Negocio.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IOrden, IOrdenImpl>();
builder.Services.AddScoped<IDaoOrden, DaoOrden>();
builder.Services.AddScoped<HelperDB>();


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
