namespace WebApiPracData.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiPracDataModels;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiPracData.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiPracData.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.Employers.AddOrUpdate(
            //  e => e.EmployerName,
            //  new Employer { Id=1, EmployerName="Boss1", EmployerAddress="1234 Street Ave Houston, Texas1", EmployerPhoneNumber="123-456-7891", EmployerEmail="email1@email.com" },
            //  new Employer { Id = 2, EmployerName = "Boss2", EmployerAddress = "5678 Street Ave Houston, Texas2", EmployerPhoneNumber = "123-456-7892", EmployerEmail = "email2@email.com" },
            //  new Employer { Id=3, EmployerName="Boss3", EmployerAddress="9012 Street Ave Houston, Texas3", EmployerPhoneNumber="123-456-7893", EmployerEmail="email3@email.com" }
            //  );
            //context.Categories.AddOrUpdate(
            //  c => c.CategoryName,
            //  new Category { Id=1, CategoryName="Administration"}
            //  );
            //context.Jobs.AddOrUpdate(
            //  j => j.JobTitle,
            //  new Job { Id=1, JobTitle="Title1", JobDescription="Description1", EmployerId=1, CategoryId=1 },
            //  new Job { Id=2, JobTitle="Title1", JobDescription="Description1", EmployerId=2, CategoryId=1 },
            //  new Job { Id=3, JobTitle="Title1", JobDescription="Description1", EmployerId=3, CategoryId=1 }
            //  );

            var RoleStore = new RoleStore<IdentityRole>(context);
            var RoleManager = new RoleManager<IdentityRole>(RoleStore);

            if (!RoleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                RoleManager.Create(role);   
        
            }
            context.SaveChanges();

            var UserStore = new UserStore<ApplicationUser>(context);
            var UserManager = new UserManager<ApplicationUser>(UserStore);

            ApplicationUser user1;
            ApplicationUser user2;

            if (context.Users.Any(i => i.UserName == "Rudy"))
            {
                user1 = context.Users.FirstOrDefault(i => i.UserName == "Rudy");
            }
            else
            {
                user1 = new ApplicationUser { UserName = "rudy" };
                UserManager.Create(user1, "rudypassword");
                UserManager.AddToRole(user1.Id, "Admin");
            }

            if (context.Users.Any(i => i.UserName == "John"))
            {
                user2 = context.Users.FirstOrDefault(i => i.UserName == "John");
            }
            else
            {
                user2 = new ApplicationUser { UserName = "john" };
                UserManager.Create(user2, "johnpassword");
                UserManager.AddToRole(user2.Id, "Admin");
            }
            context.SaveChanges();
        
        
        
        
        }           
    }
}
