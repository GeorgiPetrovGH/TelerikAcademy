namespace MvcTemplate.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MvcTemplate.Data;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        private SeedData seeder;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.seeder = new SeedData();
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            this.seeder.SeedRoles(context);
            this.seeder.SeedAdmin(context);
            this.seeder.SeedUser(context);

            context.SaveChanges();
        }
    }
}
