using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.webUI
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole==null)
            {
                await roleManager.CreateAsync(new AppRole{Name="Admin"});
            }
            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole==null)
            {
                await roleManager.CreateAsync(new AppRole{Name="Member"});
            }

            var adminUser = await userManager.FindByNameAsync("baris");
            if (adminUser==null)
            {
                AppUser user = new AppUser{
                    Name="Baris",
                    SurName="Kabal",
                    UserName="baris",
                    Email="baris@gmail.com"
                };
                await userManager.CreateAsync(user,"1");
                await userManager.AddToRoleAsync(user,"Admin");
            }
        }
    }
}