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

            var users = context.Users.Take(5).ToList();
            var categories = context.Categories.ToList();

            this.seeder.SeedSinglePlace(context, "The Little things", "Nice cosy place", categories[10], users[0]);
            this.seeder.SeedSinglePlace(context, "Sun and Moon", "Nice cosy place", categories[4], users[0]);
            this.seeder.SeedSinglePlace(context, "Mimas", "Fuck that place", categories[7], users[0]);

            context.SaveChanges();
        }
    }
}
