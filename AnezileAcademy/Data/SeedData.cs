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
            string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
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
            {
                var user = new ApplicationUser
                {
                    FirstName = "student1",
                    LastName = "student2",
                    UserName = "st@anezileacademy.co.za",
                    Email = "st@anezileacademy.co.za",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(user);
                await userManager.AddPasswordAsync(user, "123Qwe!");
                await userManager.AddToRoleAsync(user, StudentRoleName);
            }

            if (await userManager.FindByIdAsync(ADMIN_ID) == null)
            {
                var user = new ApplicationUser
                {
                    FirstName = "Parent1",
                    LastName = "Parent2",
                    UserName = "pa@anezileacademy.co.za",
                    Email = "pa@anezileacademy.co.za",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(user);
                await userManager.AddPasswordAsync(user, "123Qwe!");
                await userManager.AddToRoleAsync(user, ParentRoleName);
            }

            if (await userManager.FindByIdAsync(ADMIN_ID) == null)
            {
                var user = new ApplicationUser
                {
                    FirstName = "teacher1",
                    LastName = "teacher2",
                    UserName = "te@anezileacademy.co.za",
                    Email = "te@anezileacademy.co.za",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(user);
                await userManager.AddPasswordAsync(user, "123Qwe!");
                await userManager.AddToRoleAsync(user, TeacherRoleName);
            }

            if (await userManager.FindByIdAsync(ADMIN_ID) == null)
            {
                var user = new ApplicationUser
                {
                    Id = ADMIN_ID,
                    UserName = "admin@anezileacademy.co.za",
                    Email = "admin@anezileacademy.co.za",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(user);
                await userManager.AddPasswordAsync(user, "123Qwe!");
                await userManager.AddToRoleAsync(user, AdminRoleName);
            }
        }
    }
}
