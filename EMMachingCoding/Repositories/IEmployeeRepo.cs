using EMMachingCoding.Domain;

namespace EMMachingCoding.Repositories
{
    public interface IEmployeeRepo
    {
        public Task<List<Employee>> GetAllEmployeesAsync();

        public Task<Employee?> GetEmployeesByIdAsync(int id);

        public Task<Employee> AddEmployee(Employee emp);

        public Task UpdateEmployeeAsync(Employee emp);

        public Task DeleteEmployeeAsync(Employee emp);

    }
}
