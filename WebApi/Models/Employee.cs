using System.ComponentModel.DataAnnotations;
using WebApi.Models.Interfaces;

namespace WebApi.Models
{
    public class Employee : IEmployee
    {
        [Required] public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public DateTime HireDate { get; set; }
        [Required] public decimal Salary { get; set; }
    }
}
