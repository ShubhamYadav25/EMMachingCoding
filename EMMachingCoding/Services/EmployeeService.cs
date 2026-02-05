using EMMachingCoding.Domain;
using EMMachingCoding.Repositories;

namespace EMMachingCoding.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeService(IEmployeeRepo employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        public Task<List<Employee>> GetAllEmployeesAsync()
        {
            return _employeeRepo.GetAllEmployeesAsync();
        }

        public async Task<Employee> AddEmployee(EmployeeDto dto)
        {
            var emp = new Employee
            {
                Name = dto.Name,
                Email = dto.Email,
                Department = dto.Department,
                Salary = dto.Salary
            };
            return await _employeeRepo.AddEmployee(emp);
        }

        public async Task UpdateEmployeeAsync(int id, EmployeeDto dto)
        {
            var employee = await _employeeRepo.GetEmployeesByIdAsync(id);

            if(employee == null)
            {
                throw new Exception("Employee not found");
            }

            employee.Name = dto.Name;
            employee.Email = dto.Email;
            employee.Department = dto.Department;
            employee.Salary = dto.Salary;

            await _employeeRepo.UpdateEmployeeAsync(employee);

        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var emp = await _employeeRepo.GetEmployeesByIdAsync(id)
            ?? throw new Exception("Employee not found");

            await _employeeRepo.DeleteEmployeeAsync(emp);
        }

    }
}
