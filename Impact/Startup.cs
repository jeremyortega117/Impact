using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Impact
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // -- necessary for CORS -----------------------------------------------------
        readonly string MyAllowSpecificationOrigins = "_myAllowSpecificOrigins";
        //----------------------------------------------------------------------------



        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            
            
            //- CORS-------------------------------------------------------------------
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificationOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin().
                    AllowAnyHeader().
                    AllowAnyMethod();
                });
            });
            //---------------------------------------------------------------------------



            // - SWAGGER ----------------------------------------------------------------
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Contact API",
                    Description = "API describes the collection of general r" +
                        "oadside issues the local population may want to voice",
                    //TermsOfService = new Uri("https://poppoppotholes.azurewebsites.net/api/issue"),
                    TermsOfService = new Uri("localhost:4200/api/issue"),
                    Contact = new OpenApiContact
                    {
                        Name = "Jeremy",
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under Impact",
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //options.IncludeXmlComments(xmlPath);
            });
            // ---------------------------------------------------------------------------

            string connectionString = Configuration.GetConnectionString("ImpactDB");


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            // - Swagger -----------------------------------------------------------------
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });
            // ---------------------------------------------------------------------------



            // CORS ---------------------------------
            app.UseCors(MyAllowSpecificationOrigins);
            // ---------------------------------------



            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    internal class ImpactDB
    {
    }
}
