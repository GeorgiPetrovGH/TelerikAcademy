namespace MvcTemplate.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MvcTemplate.Common;    

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

    }
}
