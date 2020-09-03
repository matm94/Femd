using AutoMapper;
using FemdAPI.Core.Data;
using FemdAPI.Core.Repositories;
using FemdAPI.Infrastructure;
using FemdAPI.Infrastructure.AutomapperProfile;
using FemdAPI.Infrastructure.Options;
using FemdAPI.Infrastructure.Repositories;
using FemdAPI.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;

namespace FemdAPI.Api
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
            services.AddScoped<SampleData>();
            services.AddControllers();
            services.AddDbContext<FemdApiContext>();

            services.AddScoped<JwtOptions>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ILectureRepository, LectureRepository>();
            services.AddScoped<ILectureService, LectureService>();
            services.AddScoped<IJwtService, JwtService>();

            services.AddAutoMapper(typeof(FemdProfile));
            services.AddAuthorization(x => x.AddPolicy("ADMIN", x => x.RequireRole("admin")));
            
            //to do  -> DI and move to Options folder in Infrastructure all swagger configuration and jwt too
            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("V1", new OpenApiInfo() { Title = "FemdAPI", Version = "V1" });

                cfg.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization Token"
                });

                cfg.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { 
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }

                        },
                    new string []{ }
                    }
                });

                services.AddCors();

            });

            var jwtSettingsSection = Configuration.GetSection("JwtSettings");
            services.Configure<JwtOptions>(jwtSettingsSection);

            var jwtSettings = jwtSettingsSection.Get<JwtOptions>();
            var SecretKey = Encoding.UTF8.GetBytes(jwtSettings.SecretKey);


            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.SaveToken = false;

                opt.TokenValidationParameters = new TokenValidationParameters
                {

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
                    ValidIssuer = jwtSettings.Issuer,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero,

                    /* ValidIssuer = jwtSettings.Issuer,
                     ValidateAudience = false,
                     IssuerSigningKey = new SymmetricSecurityKey(
                         Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
                    */
                };
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SampleData sampleData)
        {
      
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(cfg =>
            {
                cfg.SwaggerEndpoint("/swagger/V1/swagger.json", "FemdApi");

            });

            app.UseCors(builder =>
                builder.WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            sampleData.GetSampleData();


        }
    }
}
