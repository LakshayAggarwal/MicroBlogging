namespace DataAccessLayer.Migrations
{
    using ModelDTO;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var users = new List<User>
            {

                new User { EmailId="lakshay@gmail.com", Name ="Lakshay", PhoneNumber="8123456789", Password="pass@123",  CountryOfOrigin="India", Image = "dummy data"}

            };
            users.ForEach(p => context.Users.Add(p));

            context.SaveChanges();
        }
    }
}
