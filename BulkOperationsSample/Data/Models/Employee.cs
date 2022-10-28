using System.ComponentModel.DataAnnotations;

namespace BulkOperationsSample.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string City { get; set; }
    }
}
