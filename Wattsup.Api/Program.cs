using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Wattsup.Api.Extensions;
using Wattsup.DAL.Database;


var builder = WebApplication.CreateBuilder(args);

// Add services to container
builder.Services
	.AddControllers()
	.AddJsonOptions(options =>
	{
		options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
	});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDocumentation();
builder.Services.AddServices();

builder.Services.AddCorsPolicy();

// Configure database
string connectionString = builder.Configuration.GetConnectionString("vm");
builder.Services.AddDbContext<WattsupDbContext>(options =>
{
	options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
	app.UseSwaggerDocumentation();
}

app.UseHttpsRedirection();
app.UseCors("FFA");
app.UseAuthorization();
app.MapControllers();
app.Run();
