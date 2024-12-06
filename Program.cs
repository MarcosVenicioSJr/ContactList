using ContactList.Context;
using ContactList.Interfaces;
using ContactList.Repository;
using ContactList.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("ContactDataBase");

builder.Services.AddDbContext<ContactListContext>(options =>
{
    options.UseSqlServer(connectionString).LogTo(Console.WriteLine, LogLevel.Information);
});

builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>();

builder.Services.AddScoped<ContactListContext>();

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
