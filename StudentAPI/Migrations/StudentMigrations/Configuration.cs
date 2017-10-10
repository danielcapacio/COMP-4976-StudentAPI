namespace StudentAPI.Migrations.StudentMigrations
{
    using StudentAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\StudentMigrations";
        }

        protected override void Seed(StudentAPI.Models.ApplicationDbContext context)
        {
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
            context.Students.AddOrUpdate(
            a => a.StudentId,
                getStudents(context).ToArray()
            );
            context.SaveChanges();
        }

        private List<Student> getStudents(ApplicationDbContext context)
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    StudentId = "A00111111",
                    FirstName = "John",
                    LastName = "Archer",
                    Program = "CIT"
                },
                new Student()
                {
                    StudentId = "A00222222",
                    FirstName = "Jane",
                    LastName = "Baker",
                    Program = "CST"
                },
                new Student()
                {
                    StudentId = "A00333333",
                    FirstName = "Bill",
                    LastName = "Carter",
                    Program = "BTECH"
                },
                new Student()
                {
                    StudentId = "A00444444",
                    FirstName = "Judy",
                    LastName = "Fisher",
                    Program = "Nursing"
                }
            };
            return students;
        }
    }
}
