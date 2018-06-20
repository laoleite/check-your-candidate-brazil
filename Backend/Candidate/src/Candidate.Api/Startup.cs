using Candidate.Api.Extensions;
using Candidate.Api.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;

namespace Candidate.Api
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore().AddJsonFormatters(options =>
                {
                    options.Formatting = Formatting.Indented;
                    options.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
                    options.PreserveReferencesHandling = PreserveReferencesHandling.Objects;

                }).AddApiExplorer();

            services.AddMvc();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Check Your Candidate",
                    Description = "Check Your Candidate API Swagger",
                    Contact = new Contact
                    {
                        Name = "Check Your Candidate"
                    }
                });
            });

            services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

            services.AddDependencyInjection();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware(typeof(ErrorHandlingMiddleware));

            app.UseMvc();
            app.UseStaticFiles();

            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("../swagger/v1/swagger.json", "Check Your Candidate Project API v1.0");
            });
        }
    }
}
