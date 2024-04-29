using System.ComponentModel.DataAnnotations;

namespace FrontendWebApp.Models
{
    public class Employee 
    {
        [Required] public int id { get; set; }
        [Required] public string firstName { get; set; }
        [Required] public string lastName { get; set; }
        [Required] public DateTime hireDate { get; set; }
        [Required] public decimal salary { get; set; }
    }
}
