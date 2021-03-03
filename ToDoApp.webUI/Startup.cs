using AutoMapper;
using AutoMapper.Configuration;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using ToDoApp.Business.DiContainer;
using ToDoApp.Business.ValidationRules.FluentValidation;
using ToDoApp.Data.Concrete.EFCore.Contexts;
using ToDoApp.DTO.DTOs.AciliyetDtos;
using ToDoApp.DTO.DTOs.AppUserDtos;
using ToDoApp.DTO.DTOs.GorevDtos;
using ToDoApp.DTO.DTOs.RaporDtos;
using ToDoApp.Entities.Concrete;
using ToDoApp.webUI.CustomCollectionExtensions;

namespace ToDoApp.webUI
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddContainerWithDependencies();

            services.AddDbContext<ToDoContext>();
            services.AddCustomIdentity();

            services.AddAutoMapper(typeof(Startup));

            services.AddCustomValidator();

            services.AddControllersWithViews().AddFluentValidation();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStatusCodePagesWithReExecute("/Home/StatusCode","?code={0}");
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            IdentityInitializer.SeedData(userManager,roleManager).Wait();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"areas",
                    pattern:"{area}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
