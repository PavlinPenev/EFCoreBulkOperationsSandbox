using BulkOperationsSample.Data.Models;

namespace BulkOperationsSample.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> AddBulkDataAsync();

        Task<List<Employee>> UpdateBulkDataAsync();

        Task<List<Employee>> DeleteBulkDataAsync();

        Task<List<Employee>> MergeBulkDataAsync();
    }
}
