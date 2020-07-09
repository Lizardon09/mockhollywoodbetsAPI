using System;
using System.Collections.Generic;
using System.Linq;
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
using MockHollywoodBets.DataManagers;
using MockHollywoodBets.DataManagers.Repository;
using MockHollywoodBets.DataManagers.Repository.Implimentations;
using MockHollywoodBets.DataManagers.Repository.Interfaces;
using MockHollywoodBets.Models;

namespace MockHollywoodBets
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
            services.AddDbContext<MockHollywoodBetsContext>(options => {
                options.UseSqlServer(
                        Configuration.GetConnectionString("MyConnectionString")
                        );
            }
            );

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                        );
            });

            services.AddScoped<ISportTreeRepository, SportTreeRepository>();
            services.AddScoped<ISportCountryRepository, SportCountryRepository>();
            services.AddScoped<ITournamentRepository, TournamentRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IBettypeRepository, BettypeRepository>();
            services.AddScoped<IMarketRepository, MarketRepository>();
            services.AddScoped<IDataBase, DBService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            loggerFactory.AddLog4Net();

        }
    }
}
