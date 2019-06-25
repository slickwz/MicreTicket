using MicreTicket.Api.Middlewares;
using MicreTicket.Application;
using MicreTicket.Common.Repository;
using MicreTicket.Domain.Context;
using MicreTicket.Domain.Repository;
using MicreTicket.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MicreTicket.Api
{
    public class Startup
    {
        private ILogger<Startup> logger;
        public Startup(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            Configuration = configuration;
            logger = loggerFactory.CreateLogger<Startup>();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<EFCoreContext>(option => option.UseSqlServer(Configuration["mssql:ConnectionString"]));
            services.AddScoped<DbContext, EFCoreContext>();
            services.AddTransient<IRepository, EFCoreRepository>();
            services.AddTransient<IProductRepository, ProductEFCoreRepository>();
            services.AddTransient<IDealerRepository, DealerEFCoreRepository>();
            services.AddTransient<ProductSPUService, ProductSPUService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.Use(async (context, next) =>
            {
                await next();
            });

            app.UseTest();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
