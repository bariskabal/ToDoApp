using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Business.Concrete;
using ToDoApp.Business.Interfaces;
using ToDoApp.Data.Concrete.EFCore.Repository;
using ToDoApp.Data.Interfaces;

namespace ToDoApp.Business.DiContainer
{
    public static class CustomExtensions
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<IGorevService,GorevManager>();
            services.AddScoped<IGorevDal,EFGorevRepository>();

            services.AddScoped<IBildirimService,BildirimManager>();
            services.AddScoped<IBildirimDal,EFBildirimRepository>();

            services.AddScoped<IAciliyetService,AciliyetManager>();
            services.AddScoped<IAciliyetDal,EFCoreAciliyetRepository>();

            services.AddScoped<IRaporService,RaporManager>();
            services.AddScoped<IRaporDal,EFRaporRepository>();

            services.AddScoped<IAppUserService,AppUserManager>();
            services.AddScoped<IAppUserDal,EFAppUserRepository>();

            services.AddScoped<IDosyaService,DosyaManager>();
        }
    }
}