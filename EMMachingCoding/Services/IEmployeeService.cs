using EMMachingCoding.Domain;

namespace EMMachingCoding.Services
{
    public interface IEmployeeService
    {
        public Task<List<Employee>> GetAllEmployeesAsync();

        public Task<Employee> AddEmployee(EmployeeDto emp);

        public Task UpdateEmployeeAsync(int id, EmployeeDto emp);

        public Task DeleteEmployeeAsync(int id);
    }
}
