namespace MVC_CodeAlong_110518_Amer.Migrations
{
    using MVC_CodeAlong_110518_Amer.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_CodeAlong_110518_Amer.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_CodeAlong_110518_Amer.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Employee person = new Employee() { FirstName = "Per", LastName = "Svensson", Salary = 90000, Department = "Aquisitions", Position = "Thief" };
            context.Employees.AddOrUpdate(t=> t.FirstName,person);
        }
    }
}
