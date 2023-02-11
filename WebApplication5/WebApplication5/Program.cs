using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WebApplication5;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CityContext>(options => options.UseSqlite("Data Source=D:\\Политех второй курс\\ПРиТПО\\WebApplication4\\WebApplication4\\bin\\Debug\\net6.0\\helloapp.db"));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
