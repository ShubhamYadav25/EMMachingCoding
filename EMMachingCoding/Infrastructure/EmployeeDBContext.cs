using EMMachingCoding.Domain;
using Microsoft.EntityFrameworkCore;

//Microsoft.EntityFrameworkCore 9.0.12
//Microsoft.EntityFrameworkCore.SqlServer 9.0.12
//Microsoft.EntityFrameworkCore.Tools LATEST

//namespace EMMachingCoding.Infrastructure
//{
//    public class EmployeeDBContext : DbContext
//    {
//        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> dbContextOptions) : base(dbContextOptions) { }

//        public DbSet<Employee> Employees { get; set; }
//    }
//}

//Microsoft.EntityFrameworkCore 9.0.12
//Npgsql.EntityFrameworkCore.PostgreSQL   9.0.12
//Microsoft.EntityFrameworkCore.Tools LATEST
namespace EMMachingCoding.Infrastructure
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Employee> Employee { get; set; }
    }
}
