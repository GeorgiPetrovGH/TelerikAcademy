namespace MvcTemplate.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.IO;    
    using System.Linq;
    using System.Reflection;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using MvcTemplate.Common;    

    public class SeedData
    {
        private static Random rand = new Random();

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
                UserName = "Admin site",
                FirstName = "Admin12",
                LastName = "Admin12"
            };

            userManager.Create(admin, GlobalConstants.AdminPassword);
            userManager.SetLockoutEnabled(admin.Id, false);
            userManager.AddToRole(admin.Id, GlobalConstants.AdminRole);

            context.SaveChanges();
        }

        public void SeedUser(ApplicationDbContext context)
        {
            var userStore = new UserStore<User>(context);
            var userManager = new UserManager<User>(userStore);

            var user = new User()
            {
                Email = "user1@site.com",
                UserName = "User1 site",
                FirstName = "User1",
                LastName = "User1"
            };

            userManager.Create(user, GlobalConstants.UserPassword);
            userManager.SetLockoutEnabled(user.Id, false);
            userManager.AddToRole(user.Id, GlobalConstants.UserRole);

            context.SaveChanges();
        }

        public void SeedCategories(ApplicationDbContext context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Pizza" },
                new Category { Name = "Spaghetti" },
                new Category { Name = "Pasta" },
                new Category { Name = "Burger" },
                new Category { Name = "Gyros" },
                new Category { Name = "Falafel" },
                new Category { Name = "Doner Kebab" },                
                new Category { Name = "Junk" },
                new Category { Name = "Healthy" },
                new Category { Name = "Vegan" },
                new Category { Name = "Vegetarian" },                
                new Category { Name = "Seafood" },
                new Category { Name = "Fish" },
                new Category { Name = "French" },
                new Category { Name = "Italian" },
                new Category { Name = "Bulgarian" },
                new Category { Name = "Turkish" },
                new Category { Name = "Chinese" },
                new Category { Name = "Indian" },
                new Category { Name = "Other" },
            };

            categories.ForEach(x => context.Categories.Add(x));

            context.SaveChanges();
        }

        public void SeedSinglePlace(ApplicationDbContext context, string name, string description, Category category, User user, string imagePath)
        {
            var place = new Place
            {
                Name = name,
                Description = description,
                CreatorId = user.Id,
                CategoryId = category.Id,
                AveragePrice = rand.Next(1, 16)               
            };

            var image = this.GetDefaultImage(imagePath);
            place.Images.Add(image);

            this.SeedRandomRating(place, user);
            this.SeedRandomComments(place, user);

            context.Places.Add(place);
            context.SaveChanges();
        }

        public void SeedRandomRating(Place place, User user)
        {
            for (var i = 1; i <= 50; i++)
            {
                var rating = new Rating
                {
                    Value = rand.Next(1, 6),
                    CreatorId = user.Id
                };

                place.Ratings.Add(rating);
            }
        }

        public void SeedRandomComments(Place place, User user)
        {
            for (var i = 1; i <= 10; i++)
            {
                var comment = new Comment
                {
                    Name = "This is a random comment name",
                    Text = "This is a random comment text(" + i + ")",
                    CreatorId = user.Id
                };

                place.Comments.Add(comment);
            }
        }

        public Image GetDefaultImage(string path)
        {
            var directory = AssemblyHelpers.GetDirectoryForAssembyl(Assembly.GetExecutingAssembly());
            var file = File.ReadAllBytes(directory + path);
            var image = new Image
            {
                Content = file,
                FileExtension = path.Split('.').Last()
            };

            return image;
        }
    }
}
