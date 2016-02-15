namespace MvcTemplate.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MvcTemplate.Common;
    using Models;
    using System.Collections.Generic;

    public class SeedData
    {
        public void SeedRoles(ApplicationDbContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var adminRole = new IdentityRole(GlobalConstants.AdminRole);
            roleManager.Create(adminRole);

            var userRole = new IdentityRole(GlobalConstants.UserRole);
            roleManager.Create(userRole);

            context.SaveChanges();
        }

        public void SeedAdmin(ApplicationDbContext context)
        {
            var userStore = new UserStore<User>(context);
            var userManager = new UserManager<User>(userStore);

            var admin = new User()
            {
                Email = "admin@site.com",
                UserName = "admin@site.com",
                FirstName = "Admin",
                LastName = "Admin"
            };

            userManager.Create(admin, GlobalConstants.AdminPassword);
            userManager.SetLockoutEnabled(admin.Id, false);
            userManager.AddToRole(admin.Id, GlobalConstants.AdminRole);

            context.SaveChanges();
        }

        public void SeedCategories(ApplicationDbContext context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Pizza" },
                new Category { Name = "Spaghetti" },
                new Category { Name = "Pasta" },
                new Category { Name = "Burgers" },
                new Category { Name = "Gyros" },
                new Category { Name = "Doner Kebab" },
                new Category { Name = "Chinese" },
                new Category { Name = "Indian" },
                new Category { Name = "Junk" },
                new Category { Name = "Vegan" },
                new Category { Name = "Vegetarian" },
                new Category { Name = "Other" },
                new Category { Name = "Seafood" },
                new Category { Name = "Fish" },
                new Category { Name = "French" },
                new Category { Name = "Italian" },
                new Category { Name = "Bulgarian" },
                new Category { Name = "Turkish" },
            };

            categories.ForEach(x => context.Categories.Add(x));

            context.SaveChanges();
        }
    }
}
