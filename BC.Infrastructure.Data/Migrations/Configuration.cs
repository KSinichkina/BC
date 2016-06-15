namespace BC.Infrastructure.Data.Migrations
{
    using Domain.Core;
    using Domain.Core.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BC.Infrastructure.Data.BcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BC.Infrastructure.Data.BcContext context)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BcContext>());

            context.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                Login = "admin",
                Password = "qwerty12345",
                UserType = UserType.Admin
            });

            context.Projects.Add(new Project
            {
                Id = Guid.NewGuid(),
                Name = "������� ����",
                TotalSum = 10000,
                CurrentSum = 0,
                Description = "������ ��� ����",
                Info = "������ ����� �� ���� ����� �� ����� ������ ",
                ProjectStatus = ProjectStatus.Open,

            });

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
