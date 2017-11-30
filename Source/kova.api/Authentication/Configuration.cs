using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kova.api.Authentication
{
    public static class Configuration
    {
        private static string GetSecretKey(this IConfiguration configuration) => configuration.GetValue<string>("kova:authentication:secret");
        private static string GetIssuer(this IConfiguration configuration) => configuration.GetValue<string>("kova:authentication:issuer");
        private static string GetAudience(this IConfiguration configuration) => configuration.GetValue<string>("kova:authentication:audience");

        public static IApplicationBuilder UseKovaAuthentication(this IApplicationBuilder app, IConfiguration configuration)
        {
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration.GetSecretKey()));
            var options = new TokenProviderOptions
            {
                Audience = configuration.GetAudience(),
                Issuer = configuration.GetIssuer(),
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256),
                Expiration = TimeSpan.FromHours(1)
            };

            return app.UseAuthentication()
                .UseMiddleware<TokenProviderMiddleware>(Options.Create(options));
        }

        public static void AddKovaAuthentication(this IServiceCollection services, IConfiguration configuration)
        {

            // Add JWT generation endpoint:
            var tokenValidationParameters = new TokenValidationParameters
            {
                // The signing key must match!
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration.GetSecretKey())),

                // Validate the JWT Issuer (iss) claim
                ValidateIssuer = true,
                ValidIssuer = configuration.GetIssuer(),

                // Validate the JWT Audience (aud) claim
                ValidateAudience = true,
                ValidAudience = configuration.GetAudience(),

                // Validate the token expiry
                ValidateLifetime = true,

                // If you want to allow a certain amount of clock drift, set that here:
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = tokenValidationParameters;
                    options.RequireHttpsMetadata = false;
                });
        }
    }
}
