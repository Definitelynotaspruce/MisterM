using System;
using System.Net.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MisterM.Controllers;
using MisterM.Hubs;
using Radzen;

// how to create connection guide: https://blazorhelpwebsite.com/ViewBlogPost/34

namespace MisterM
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        partial void OnConfigureServices(IServiceCollection services);

        partial void OnConfiguringServices(IServiceCollection services);

        public void ConfigureServices(IServiceCollection services)
        {
            OnConfiguringServices(services);

            services.AddHttpContextAccessor();
            services.AddScoped<HttpClient>(serviceProvider =>
            {

              var uriHelper = serviceProvider.GetRequiredService<NavigationManager>();

              return new HttpClient
              {
                BaseAddress = new Uri(uriHelper.BaseUri)
              };
            });

            services.AddHttpClient();

            //scoped creates an instance for each user 
            services.AddScoped<MsMisterMService>();

            // set the database connection for the MSMisterM 
            services.AddDbContext<MisterM.Data.MsMisterMContext>(options =>
            {
              options.UseSqlServer(Configuration.GetConnectionString("MsMisterMConnection"));
            });
            
            services.AddRazorPages();
            services.AddServerSideBlazor().AddHubOptions(o =>
            {
                o.MaximumReceiveMessageSize = 10 * 1024 * 1024;
            });

            // Computer Manipulation Controller
            services.AddScoped<ComputerController>();

            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();
            services.AddScoped<TooltipService>();
            services.AddScoped<ContextMenuService>();

            OnConfigureServices(services);
        }

        partial void OnConfigure(IApplicationBuilder app, IWebHostEnvironment env);
        partial void OnConfiguring(IApplicationBuilder app, IWebHostEnvironment env);

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            OnConfiguring(app, env);
            if (env.IsDevelopment())
            {
                Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.Use((ctx, next) =>
                {
                    return next();
                });
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapHub<DeviceReadingHub>("/reading");
                endpoints.MapFallbackToPage("/_Host");
            });

            OnConfigure(app, env);
        }
    }


}
