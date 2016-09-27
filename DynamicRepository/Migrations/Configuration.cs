using DynamicRepository.Models;

namespace DynamicRepository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DynamicRepository.Models.ApplicationDbContext";
        }

        protected override void Seed(DynamicRepository.Models.ApplicationDbContext context)
        {
            context.Students.AddOrUpdate(new Student
                                         {
                                             Id = new Guid("234de484-dbf1-45e3-85fc-d09697c30044"),
                                             FirstName = "Tung",
                                             LastName = "Beng"
                                         });
            context.SaveChanges();
        }
    }
}
