namespace MvcTemplate.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MvcTemplate.Data;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public const string DefaultImagePath = "../../Images/default.jpg";
        public const string MimasImagePath = "../../Images/mimas.jpg";
        public const string SunMoonImagePath = "../../Images/sunmoon.jpg";
        public const string TheLittleThingsImagePath = "../../Images/thelittlethings.jpg";

        public const string SunMoonDescription = "I enjoyed the place. The location is centrical, the staff speak English, the food (specially the daily specials) is nice, and the atmosphere is inviting. The portions, in my oppinion, are reasonable, but then again my weight is reasonable, too.";
        public const string MimasDescription = "This burger has 1466 calories, which is quite impressive considering it lacks the cheese, bacon and extra beef of its rivals.";
        public const string TheLittleThingsDescription = "Cosy and romantic place. Delicious food. Great wine. Reasonable prices (kind of cheap for the quality). The only drawback being the lack of free tables. Even if you have reservation you might end up on a pretty small table with lots of people surrounding you which actually contradicts to the main idea - feeling at home.";

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
            this.seeder.SeedCategories(context);

            var users = context.Users.Take(5).ToList();
            var categories = context.Categories.ToList();

            this.seeder.SeedSinglePlace(context, "The Little things", TheLittleThingsDescription, categories[9], users[0], TheLittleThingsImagePath);
            this.seeder.SeedSinglePlace(context, "Sun and Moon", SunMoonDescription, categories[9], users[0], SunMoonImagePath);
            this.seeder.SeedSinglePlace(context, "Mimas", MimasDescription, categories[8], users[0], MimasImagePath);

            context.SaveChanges();
        }
    }
}
