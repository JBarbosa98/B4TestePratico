using B4TestePratico.Data;
using B4TestePratico.Routes;
using AppContext = B4TestePratico.Data.AppContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependence Injection
builder.Services.AddScoped<AppContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ClientRoutes();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
