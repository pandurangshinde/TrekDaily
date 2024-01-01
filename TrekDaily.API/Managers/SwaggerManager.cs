using Microsoft.OpenApi.Models;

namespace TrekDaily.API.Managers
{
	public static class SwaggerManager
	{
		public static void ConfigSwagger(
			this IServiceCollection services
		)
		{
			services.AddSwaggerGen(c =>
			{
				if (c != null)
				{
					#region General info

					c.SwaggerDoc("v1", new OpenApiInfo { Title = "Trek Daily API", Version = "v1" });

					#endregion
				}
			});
		}

	}
}
