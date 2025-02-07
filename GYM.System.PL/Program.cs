
using GYM.System.DAL.Data.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GYM.System.PL
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddDbContext<GymDbContext>(option =>
				option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
				);

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

			await ApplyMigrationsAsync(app.Services);

			await app.RunAsync(); // Use RunAsync instead of Run
		}

		private static async Task ApplyMigrationsAsync(IServiceProvider services)
		{
			using var scope = services.CreateScope();
			var loggerFactory = scope.ServiceProvider.GetRequiredService<ILoggerFactory>();
			try
			{
				var context = scope.ServiceProvider.GetRequiredService<GymDbContext>();
				await context.Database.MigrateAsync();
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<Program>();
				logger.LogError(ex, "An error occurred while applying migrations.");
			}
		}
	}
}
