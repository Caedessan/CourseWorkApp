using CourseWorkApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp
{
    public class ApplicationDataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PositionSalary> PositionSalarys { get; set; }
        public DbSet<DepartmentEmployee> DepartmentEmployees { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<Login> Logins { get; set; }

        public ApplicationDataContext() : base()
        {
        }

        public ApplicationDataContext(DbContextOptions options) : base(options)
        {
            

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9QFPCKG;Initial Catalog=Company;Integrated Security=True");
        }

        public void AddAdminRights(string username) 
        {
            var usernameParameter = new SqlParameter("@Username", System.Data.SqlDbType.NVarChar);
            usernameParameter.Value = username;

            this.Database.ExecuteSqlRaw("EXEC AddAdminRights @Username", usernameParameter);
        }

        public void AddUser(string username, string password)
        {
            var usernameParameter = new SqlParameter("@Username", System.Data.SqlDbType.NVarChar);
            usernameParameter.Value = username;
            var passwordParameter = new SqlParameter("@Password", System.Data.SqlDbType.NVarChar);
            passwordParameter.Value = username;

            this.Database.ExecuteSqlRaw("EXEC AddUser @Username, @Password", usernameParameter, passwordParameter);
        }
    }
}
