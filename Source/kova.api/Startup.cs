using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using kova.api.Authentication;
using Microsoft.Extensions.Options;
using kova.api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace kova.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("kova");
            services.AddDbContext<kovaContext>(options => options.UseSqlServer(connection));
            
            // Add DbContextOptions, so singleton classes can also depend on the DB Context
            services.AddSingleton(typeof(DbContextOptions), new DbContextOptionsBuilder().UseSqlServer(connection).Options);

            // Add framework services.
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    // Customize json generation
                    options.SerializerSettings.Converters = new JsonConverter[] {
                        new kovaJsonConverter(),
                        new PoiConverter()
                    };
                });

            // Custom kova authentication
            services.AddKovaAuthentication(Configuration);
            
            // Swagger API documentation
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info() { Title = "KOVA API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Serve any file from the .well-known folder. Required for automated certificate from letsencrypt
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @".well-known")),
                RequestPath = new PathString("/.well-known"),
                ServeUnknownFileTypes = true // serve extensionless file
            });

            // Setup kova authentication middleware
            app.UseKovaAuthentication(Configuration);

            // Alle skal få
            app.UseCors(v => v
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());

            // Standard ASPNet API     
            app.UseMvc();

            // Swagger API documentation
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Kova API v1");
            });
        }
    }
}
