
using Microsoft.OpenApi.Models;
using TrekDaily.API.Managers;

try
{
	var builder = WebApplication.CreateBuilder(args);

	builder.Services.AddControllers();
	builder.Services.ConfigSwagger();

	var app = builder.Build();

	app.UseCors(builder =>
	{
		builder.WithOrigins("http://localhost:3000")
			   .AllowAnyHeader()
			   .AllowAnyMethod()
			   .AllowCredentials(); // Add this line
	});
	app.MapGet("/", () => "Hello World!");

	app.MapControllers();
	app.UseSwagger();
	app.UseSwaggerUI();
	//app.UseRouting();
	//app.UseAuthorization();
	
	Console.WriteLine("\r\nTrekDaily.API loaded!");
	app.Run();

}
catch (Exception error)
{
	Console.WriteLine(error.Message);
	Console.WriteLine(error.StackTrace);
}
