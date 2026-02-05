using EMMachingCoding.Domain;
using EMMachingCoding.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace EMMachingCoding.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeDBContext _dbContext;

        public EmployeeRepo(EmployeeDBContext db)
        {
            _dbContext = db;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync() => await _dbContext.Employee.AsNoTracking().ToListAsync();

        public async Task<Employee?> GetEmployeesByIdAsync(int id)
        {
            return await _dbContext.Employee.FindAsync(id); 
        }

        public async Task<Employee> AddEmployee(Employee emp)
        {
            _dbContext.Employee.Add(emp);
            await _dbContext.SaveChangesAsync();
            return emp;
        }

        public async Task UpdateEmployeeAsync(Employee emp)
        {
            _dbContext.Employee.Update(emp);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(Employee emp)
        {
            _dbContext.Employee.Remove(emp);
            await _dbContext.SaveChangesAsync();
        }

    }
}
