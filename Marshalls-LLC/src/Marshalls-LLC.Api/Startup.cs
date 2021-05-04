using Marshalls_LLC.Core.Interfaces;
using Marshalls_LLC.Core.Services;
using Marshalls_LLC.Core.SharedKernel;
using Marshalls_LLC.Infrastructure.Data;
using Marshalls_LLC.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Marshalls_LLC.Api
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
            DbContextFactory.SetConnectionString(Configuration.GetConnectionString("AppConnection").ToString());
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("AppConnection"))
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(MyLoggerFactory)
                );

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<IEmployeeDataValidations, EmployeeDataValidations>();
            services.AddScoped<IOfficeRepository, OfficeRepository>();
            services.AddScoped<IOfficeServices, OfficeServices>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IPositionServices, PositionServices>();
            services.AddScoped<IDivisionRepository, DivisionRepository>();
            services.AddScoped<IDivisionServices, DivisionServices>();
          

            services.AddAutoMapper(typeof(Startup));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Marshalls_LLC.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Marshalls_LLC.Api v1"));
            }
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder
               .AddFilter((category, level) =>
                   category == DbLoggerCategory.Database.Command.Name
                   && level == LogLevel.Information)
               .AddConsole();
        });
    }

}
