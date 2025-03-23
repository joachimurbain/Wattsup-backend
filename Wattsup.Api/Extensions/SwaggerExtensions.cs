using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Wattsup.Api.Extensions;

public static class SwaggerExtensions
{
	const string appname = "Wattsup";
	const string version = "v1";
	public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
	{
		services.AddEndpointsApiExplorer();

		services.AddSwaggerGen(c =>
		{
			c.SwaggerDoc(version, new OpenApiInfo
			{
				Title = $"{appname} API",
				Version = version,
				Description = $"API documentation for {appname}"
			});
		});

		return services;
	}
	public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
	{
		app.UseSwagger();

		app.UseSwaggerUI(c =>
		{
			c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"{appname} API {version}");
		});

		return app;
	}

	public static IServiceCollection AddJwtToSwagger(this IServiceCollection services)
	{
		services.Configure<SwaggerGenOptions>(c =>
		{
			c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
			{
				Name = "Authorization",
				Type = SecuritySchemeType.Http,
				Scheme = "bearer", // must be lowercase in OpenAPI 3
				BearerFormat = "JWT",
				In = ParameterLocation.Header,
				Description = "JWT Authorization header using the Bearer scheme.\n\nExample: \"Bearer eyJhbGciOi...\""
			});

			c.AddSecurityRequirement(new OpenApiSecurityRequirement
			{
				{
					new OpenApiSecurityScheme
					{
						Reference = new OpenApiReference
						{
							Type = ReferenceType.SecurityScheme,
							Id = "Bearer"
						}
					},
					new string[] { }
				}
			});
		});

		return services;
	}

}
