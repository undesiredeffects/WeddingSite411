namespace WeddingSite411.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeddingSite411.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WeddingSite411.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeddingSite411.Models.ApplicationDbContext context)
        {
            context.RSVPModels.AddOrUpdate(p => p.Name,
                new RSVPModel
                {
                    Name = "Jim Johnson",
                    Address = "Assclown Way",
                    Email = "assface@assface.com",
                    Attending = "No"
                },

                new RSVPModel
                {
                    Name = "Farty McFartface",
                    Address = "Flatulence Boulevard",
                    Email = "beano@beano.com",
                    Attending = "Yes",
                }
                    );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
