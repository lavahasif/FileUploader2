using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorPdflist.Data;
using BlazorPdflist.Util;
using BlazorPro.BlazorSize;
using MatBlazor;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data;
using MyBlog.Data.Interfaces;
using Syncfusion.Blazor;
namespace BlazorPdflist
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddBlazorise( options =>
                {
                    options.ChangeTextOnKeyPress = true; // optional
                } )
                .AddBulmaProviders()
                .AddFontAwesomeIcons();
            services.AddMediaQueryService();
            services.AddRazorPages();
            services.AddScoped<BrowserService>();
            services.AddScoped<FileService>();
            services.AddServerSideBlazor();
        
            services.AddMatBlazor();
            services.AddDbContextFactory<MyBlogDbContext>(builder => builder.UseSqlite($"Data source=../myblog.db"));
            services.AddScoped<IMyBlogApi, MyBlogApiServerSide>();
            services.AddSingleton<WeatherForecastService>();
            //services.AddSyncfusionBlazor();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            IDbContextFactory<MyBlogDbContext> factory)
        {
            factory.CreateDbContext().Database.Migrate();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}