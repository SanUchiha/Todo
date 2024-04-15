using ListaTareas.Repo;
using ListaTareas.Aplicacion;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInjectionRepo(Configuration);
builder.Services.AddInjectionAplicacion(Configuration);

//var connectionString = builder.Configuration.GetConnectionString("CadenaConexionBD");
//builder.Services.AddDbContext<ToDoContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddCors(options =>
    options.AddPolicy("CORS", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    })
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CORS");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

//public partial class Program { }