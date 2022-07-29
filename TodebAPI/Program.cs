using Business.Abstract;
using Business.Concrete;
using Business.Configuration.Mapper;
using DAL.Abstract;
using DAL.Concrete;
using DAL.DBContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddScoped<IAccountRepository, AccountRepository>(); //Scoped Account Repository
builder.Services.AddTransient<IAccountService, AccountService>(); // Transented Account Service
builder.Services.AddDbContext<TODEBAccountDbContext>(ServiceLifetime.Scoped); // Scoped DBContext
/*
 * AUTOMAPPER Configuration on Startup
 */
builder.Services.AddAutoMapper(conf =>
{
    conf.AddProfile(new MapperProfile());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); // EndPoint Conf
builder.Services.AddSwaggerGen(); // Swagger Conf
builder.Services.AddAuthorization(); // Authorization Conf
builder.Services.AddControllers(); // Mapping Controller Conf

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // Developement Environment
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.MapControllers();

app.Run();
