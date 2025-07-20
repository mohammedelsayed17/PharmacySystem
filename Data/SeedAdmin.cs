using Microsoft.AspNetCore.Identity;
using PharmacySystem.Models;

namespace PharmacySystem.Data
{
    //public class SeedAdmin
    //{
    //    public static async Task Seed(IServiceProvider service)
    //    {
    //        var userManager = service.GetRequiredService<UserManager<ApplicationUser>>();
    //        var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

    //        string[] adminEmails = { "Amin@gmail.com", "Arafa@gmail.com" };

    //        if (!await roleManager.RoleExistsAsync("Admin"))
    //            await roleManager.CreateAsync(new IdentityRole("Admin"));

    //        foreach (var email in adminEmails)
    //        {
    //            var user = await userManager.FindByEmailAsync(email);
    //            if (user == null)
    //            {
    //                user = new ApplicationUser { UserName = email, Email = email };
    //                await userManager.CreateAsync(user, "Admin@123");
    //            }
    //            await userManager.AddToRoleAsync(user, "Admin");
    //        }
    //    }
    //}
}
