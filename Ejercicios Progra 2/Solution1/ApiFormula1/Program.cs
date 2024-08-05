using ModelosDeClases.Datos.Dao;
using ModelosDeClases.Negocio;

var builder = WebApplication.CreateBuilder(args);

// Agrega los servicios al contenedor.
builder.Services.AddControllers();

// Configuración de Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registro de servicios
builder.Services.AddScoped<IDaoFormula, DaoFormula>();
builder.Services.AddScoped<IFormulaService, FormulaService>();

var app = builder.Build();

// Configuración del pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
