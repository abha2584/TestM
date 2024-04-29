using System.ComponentModel.DataAnnotations;
using WebApi.Models.Interfaces;

namespace WebApi.Models
{
    public class Department : IDepartment
    {
        [Required] public int DepartmentId { get; set; }
        [Required] public string Name { get; set; }
    }
}
