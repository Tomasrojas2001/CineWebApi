using AccessData;
using AccessData.Commands;
using AccessData.Queries;
using AccessData.DataBaseValidations.FuncionValidations;
using Application.Services;
using Application.Services.Interface_Service;
using Domain.Commands;
using Domain.DatabaseValidations;
using Domain.Queries;
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
using Newtonsoft.Json;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AccessData.DataBaseValidations.TicketValidations;
using AccessData.DataBaseValidations.PeliculaValidations;
using AccessData.DataBaseValidations.SalaValidations;

namespace API
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
           /* //ADD TIMESPAN CONVERT
            services.AddSwaggerGen(c => {
                c.MapType<TimeSpan>(() => new OpenApiSchema { Type = "string", Format = "time-span" });
            });

            //DATETIME
            services.AddControllers()
            .AddNewtonsoftJson(options =>
            {
               var dateConverter = new Newtonsoft.Json.Converters.IsoDateTimeConverter
               {
                   DateTimeFormat = "dd'-'MM'-'yyyy"
               };

               options.SerializerSettings.Converters.Add(dateConverter);
               options.SerializerSettings.Culture = new CultureInfo("en-IE");
               options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            });*/


            services.AddControllers();
            var connectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContext<CineContext>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IGenericsRepository, GenericsRepository>();
            services.AddTransient<IFuncionQuery, FuncionQuery>();
            services.AddTransient<IPeliculaQuery, PeliculaQuery>();
            services.AddTransient<ITicketQuery, TicketQuery>();
            services.AddTransient<IFuncionService, FuncionService>();
            services.AddTransient<IPeliculaService, PeliculaService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<IFuncionValidations, FuncionValidation>();
            services.AddTransient<ITicketsValidations, TicketValidation>();
            services.AddTransient<IPeliculaValidations, PeliculaValidation>();
            services.AddTransient<ISalaValidations, SalaValidation>();

            //SQL KATA 
            services.AddTransient<Compiler , SqlServerCompiler>();
            services.AddTransient<IDbConnection>(b => 
            {
                return new SqlConnection(connectionString);
            });
            //SWAGGER
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });

            //CORS
            services.AddCors(options =>
            {
                options.AddPolicy("AnyAllow", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseCors("AnyAllow");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
