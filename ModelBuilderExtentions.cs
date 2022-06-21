using CourseWorkApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseWorkApp
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new 
                {
                Id = 1,
                Name = "Admin",
                Surname = "Admin",
                Fathersname = "Admin",
                HomeAddress = "Admin address",
                BirthDate = new DateTime(2022,04,21),
                PassportData = "No data"
                }
            );

            modelBuilder.Entity<EmployeePosition>().HasData(
                new
                {
                    Id = 1,
                    EmployeeId = 1,
                    PositionId = 1,
                    Date = new DateTime(2022,04,21)
                }
            );

            modelBuilder.Entity<Position>().HasData(
                new
                {
                    Id = 1,
                    Name = "SuperEmplyee",
                    DepartmentId = 1
                },
                new 
                {
                    Id = -1,
                    Name = "Fired",
                }
            );

            modelBuilder.Entity<Department>().HasData(
                new {
                    Id = 1,
                    Name = "Department One",
                    HeadId = 1,
                    Abbriviation = "D1"
                }
            );
        }
    }
}
