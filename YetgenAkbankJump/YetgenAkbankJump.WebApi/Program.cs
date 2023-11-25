using Microsoft.EntityFrameworkCore;
using YetgenAkbankJump.Persistence.Contexts;
using YetGenAkbankJump.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetSection("YetgenPostgreSQLDB").Value;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
	options.UseNpgsql(connectionString);
});

builder.Services.AddScoped<FakeDataService>();

builder.Services.AddMemoryCache();




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
