using Microsoft.EntityFrameworkCore;
using System.Configuration;
using joelkozek.comapi2.Models.Review;
using joelkozek.comapi2.Models.Todo;
using joelkozek.comapi2.Models.Employee;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDbContext<ReviewContext>(options =>
                options.UseMySQL(builder.Configuration.GetConnectionString("bestbuy")));
builder.Services.AddDbContext<EmployeeContext>(options =>
                options.UseMySQL(builder.Configuration.GetConnectionString("bestbuy")));

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
