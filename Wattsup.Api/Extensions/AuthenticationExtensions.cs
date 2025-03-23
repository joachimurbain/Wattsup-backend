namespace Wattsup.Api.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
public static class AuthenticationExtensions
{
	public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddAuthentication(options =>
		{

			options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
			options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
		})
		.AddJwtBearer(option =>
		{
			option.TokenValidationParameters = new TokenValidationParameters()
			{
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(
					Encoding.UTF8.GetBytes(configuration["Jwt:Key"])
				),

				ValidateIssuer = true,
				ValidIssuer = configuration["Jwt:Issuer"],

				ValidateAudience = true,
				ValidAudience = configuration["Jwt:Audience"],

				//ValidateLifetime = true
			};
		});
		return services;
	}
}
