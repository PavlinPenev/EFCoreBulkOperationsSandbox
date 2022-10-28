using BulkOperationsSample.Data;
using BulkOperationsSample.Data.Models;
using System.Linq;

namespace BulkOperationsSample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Employee>> AddBulkDataAsync()
        {
            List<Employee> employees = new();

            for (int i = 0; i < 500; i++)
            {
                employees.Add(new Employee()
                {
                    Name = "Employee_" + i,
                    Designation = "Designation_" + i,
                    City = "City_" + i
                });
            }
            await _appDbContext.BulkInsertAsync(employees);

            var result = _appDbContext.Employees.Take(10).ToList();

            return result;
        }

        public async Task<List<Employee>> UpdateBulkDataAsync()
        {
            List<Employee> employees = new();
            for (int i = 0; i < 500; i++)
            {
                employees.Add(new Employee()
                {
                    Id = (i + 1),
                    Name = "Update Employee_" + i,
                    Designation = "Update Designation_" + i,
                    City = "Update City_" + i
                });
            }
            await _appDbContext.BulkUpdateAsync(employees);

            var result = _appDbContext.Employees.Take(10).ToList();

            return result;
        }

        public async Task<List<Employee>> DeleteBulkDataAsync()
        {
            List<Employee> employees = new(); 
            employees = _appDbContext.Employees.ToList();
            await _appDbContext.BulkDeleteAsync(employees);

            var result = _appDbContext.Employees.Take(10).ToList();

            return result;
        }

        public async Task<List<Employee>> MergeBulkDataAsync()
        {
            List<Employee> employees = new();

            for (int i = 0; i < 1000; i++)
            {
                employees.Add(new Employee()
                {
                    Id = (i + 1),
                    Name = "Merge Employee_" + i,
                    Designation = "Merge Designation_" + i,
                    City = "Merge City_" + i
                });
            }
            await _appDbContext.BulkMergeAsync(employees);

            var result = _appDbContext.Employees.Take(10).ToList();

            return result;
        }
    }
}
