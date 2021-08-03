using System.Text;
using ATSBackend.Domain.Services;
using ATSBackend.Application.Services;
using ATSBackend.Application.Interfaces;
using ATSBackend.Domain.Interfaces.Services;
using ATSBackend.Domain.Interfaces.Repositories;
using ATSBackend.Infra.Data.Contexts;
using ATSBackend.Infra.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace ATSBackend.Service
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();

            services.AddSwaggerGen();

            services.AddAutoMapper(typeof(Startup));

            #region Scoped
            services.AddScoped<ICandidatoApplication, CandidatoApplication>();
            services.AddScoped<ICandidatoService, CandidatoService>();
            services.AddScoped<ICandidatoRepository, CandidatoRepository>();

            services.AddScoped<ICurriculoApplication, CurriculoApplication>();
            services.AddScoped<ICurriculoService, CurriculoService>();
            services.AddScoped<ICurriculoRepository, CurriculoRepository>();

            services.AddScoped<IVagaApplication, VagaApplication>();
            services.AddScoped<IVagaService, VagaService>();
            services.AddScoped<IVagaRepository, VagaRepository>();

            services.AddScoped<IExperienciaApplication, ExperienciaApplication>();
            services.AddScoped<IExperienciaService, ExperienciaService>();
            services.AddScoped<IExperienciaRepository, ExperienciaRepository>();
            #endregion

            services.AddControllersWithViews();
            services.AddDbContext<ATSContext>(options =>
                options.UseSqlServer(@"Data Source =.\sqlexpress; Initial Catalog = ATSTeste; Integrated Security = True"));

            var key = Encoding.ASCII.GetBytes(Settings.SecretKey());

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(c => c.MapControllers());
        }
    }
}