using APINOTES.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// create variable conexionString.....
 var mySqlConexionString = builder.Configuration.GetConnectionString("DefaultConnection");
// register services to conexion
builder.Services.AddDbContext<ApiContext>(options => options.UseMySql(mySqlConexionString, ServerVersion.AutoDetect(mySqlConexionString)));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Otros servicios...

//builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowSpecificOrigin", builder =>
//         builder.WithOrigins("http://localhost:5500") // Reemplaza con tu URL de JavaScript
//                .AllowAnyHeader()
//                .AllowAnyMethod());
// });



// Otros middlewares...




    // Otros middlewares...


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(origin => true).AllowCredentials());
        


app.UseAuthorization();

app.MapControllers();

app.Run();
