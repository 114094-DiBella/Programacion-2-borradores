using ClassLibrary1.datos;
using ClassLibrary1.negocio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register all the necessary services
builder.Services.AddSingleton<HelperDao>();
builder.Services.AddScoped<IRecetaDao, RecetaDao>();
builder.Services.AddScoped<IReceta, IRecetaImpl>();

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
