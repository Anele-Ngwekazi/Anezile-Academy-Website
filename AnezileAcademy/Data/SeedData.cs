using AnezileAcademy.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnezileAcademy.Data
{
    public class SeedData
    {
        public  static async Task Initialize(ApplicationDbContext context,
                                             UserManager<ApplicationUser> userManager,
                                             RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            string AdminRoleName = "admin";
            string TeacherRoleName = "teacher";
            string ParentRoleName = "parent";
            string StudentRoleName = "student";
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            var hasher = new PasswordHasher<ApplicationUser>();

            if (await roleManager.FindByNameAsync(AdminRoleName) == null)
                await roleManager.CreateAsync(new IdentityRole(AdminRoleName));
            if (await roleManager.FindByNameAsync(TeacherRoleName) == null)
                await roleManager.CreateAsync(new IdentityRole(TeacherRoleName));
            if (await roleManager.FindByNameAsync(ParentRoleName) == null)
                await roleManager.CreateAsync(new IdentityRole(ParentRoleName));
            if (await roleManager.FindByNameAsync(StudentRoleName) == null)
                await roleManager.CreateAsync(new IdentityRole(StudentRoleName));
           
            if (await userManager.FindByIdAsync(ADMIN_ID) == null)
                await userManager.CreateAsync(new ApplicationUser
                {
                    Id = ADMIN_ID,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "admin@anezileacademy.co.za",
                    NormalizedEmail = "admin@anezileacademy.co.za",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123Qwe!"),
                    SecurityStamp = string.Empty
                });

        }
    }
}
