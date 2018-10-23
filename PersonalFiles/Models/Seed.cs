using Microsoft.AspNetCore.Identity;
using PersonalFiles.DAL;

namespace PersonalFiles
{
    public class Seed
    {
        public static async System.Threading.Tasks.Task InitializeDataAsync(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            var existRole = await roleManager.FindByNameAsync("Admin");
            if (existRole == null)
            {
                string[] roleNames = { "Admin", "WriteAndRead", "Read" };

                foreach(string roleName in roleNames)
                {
                    await roleManager.CreateAsync(new ApplicationRole(roleName));
                }
            }

            var existUser = await userManager.FindByNameAsync("Admin");
            if (existUser == null)
            {
                var admin = new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "admin@mail.ru",
                    IsDeleted = false
                };
                var createdAdmin = await userManager.CreateAsync(admin, "Admin1;");
                if (createdAdmin.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                }

                var writeAndreadUser = new ApplicationUser
                {
                    UserName = "Writer",
                    Email = "writer@mail.ru",
                    IsDeleted = false
                };
                var createdWriter = await userManager.CreateAsync(writeAndreadUser, "Writer1;");
                if (createdWriter.Succeeded)
                {
                    await userManager.AddToRoleAsync(writeAndreadUser, "WriteAndRead");
                }

                var readUser = new ApplicationUser
                {
                    UserName = "Reader",
                    PasswordHash = "Reader",
                    Email = "reader@mail.ru",
                    IsDeleted = false
                };
                var createdReader =  await userManager.CreateAsync(readUser, "Reader1;");
                if (createdReader.Succeeded)
                {
                    await userManager.AddToRoleAsync(readUser, "Read");
                }
            }


        }
    }
}
