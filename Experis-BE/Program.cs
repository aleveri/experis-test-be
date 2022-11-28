using Experis_BE_Application.Base;
using Experis_BE_Domain.Interfaces;
using Experis_BE_Domain.Models;
using Experis_BE_Infrastructure.Contexts;
using Experis_BE_Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SqlContext>();
builder.Services.AddTransient<IResponse, Response>();
builder.Services.AddScoped(typeof(ISqlRepository<>), typeof(SqlRepository<>));
builder.Services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
