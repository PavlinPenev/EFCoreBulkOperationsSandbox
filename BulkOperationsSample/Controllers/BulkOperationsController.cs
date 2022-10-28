using BulkOperationsSample.Data.Models;
using BulkOperationsSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace BulkOperationsSample.Controllers
{
    [Route("BulkOperations")]
    public class BulkOperationsController : Controller
    {
        private readonly IEmployeeService employeeService;

        public BulkOperationsController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<List<Employee>> BulkAddDataAsync()
        {
            return await employeeService.AddBulkDataAsync();
        }

        [HttpPut]
        [Route("Update")]
        public async Task<List<Employee>> BulkUpdateDataAsync()
        {
            return await employeeService.UpdateBulkDataAsync();
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<List<Employee>> BulkDeleteDataAsync()
        {
            return await employeeService.DeleteBulkDataAsync();
        }

        [HttpPut]
        [Route("Merge")]
        public async Task<List<Employee>> BulkMergeDataAsync()
        {
            return await employeeService.MergeBulkDataAsync();
        }
    }
}
