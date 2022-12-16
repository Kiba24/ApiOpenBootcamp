using Microsoft.EntityFrameworkCore;
using OpenBootcampAPI.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//1.Connexion con SQL
const string cnnName = "UniversityDb";
var connectionString = builder.Configuration.GetConnectionString(cnnName);

//2.ADD DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.



builder.Services.AddControllers();
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
