using AutoMapper;
using Group15.EventManager.Application.AutoMapper;
using Group15.EventManager.Bootstrapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Microsoft.OpenApi.Models;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Group15.EventManager.Domain.Models.Auth;
using Microsoft.AspNetCore.Identity;
using FluentValidation.AspNetCore;
using Group15.EventManager.Data.Context;
using System;
using Group15.EventManager.Shared.Auth.Policies;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //DB
            services.AddDbContext<SqlContext>();

            services.AddDefaultIdentity<ApplicationUser>()
                    .AddRoles<IdentityRole<Guid>>()
                    .AddEntityFrameworkStores<SqlContext>()
                    .AddDefaultTokenProviders();
            
            services.RegisterServices();

            //JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["JwtIssuer"],
                        ValidAudience = Configuration["JwtAudience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"]))
                    };  
                });

            services.AddAuthorization(config =>
            {
                config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
                config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
            });

            services.AddAutoMapperSetup(typeof(Startup).Assembly);
            services.AddMediatR(typeof(Startup));

            services.AddMvc()
                    .AddFluentValidation()
                    .AddNewtonsoftJson();

            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });

            //SWAGGER
            //services.AddSwaggerGen(setup =>
            //{
            //    setup.SwaggerDoc("v1", new OpenApiInfo() { Title = "Event Manager", Version = "Version 1" });
            //});
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBlazorDebugging();
            }

            //Swagger
            //app.UseSwagger();
            //app.UseSwaggerUI(config =>
            //{
            //    config.SwaggerEndpoint("swagger/v1/swagger.json", "Event Manager v1");
            //    config.RoutePrefix = string.Empty;
            //});

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseClientSideBlazorFiles<Client.Startup>();

            app.UseRouting();

            //DO NOT TOUCH IMPORTANT --> UseAuthorization must be between UseRouting() and UseEndPoints()
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapFallbackToClientSideBlazor<Client.Startup>("index.html");
            });
        }
    }
}
