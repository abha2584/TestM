using WebApi.Models;

namespace WebApi.Repositories
{
    public class DepartmentRepository
    {
        public static List<Department> Departments()
        {
            return new List<Department>()
            {
               new Department {DepartmentId = 1, Name = "Technology" },
               new Department {DepartmentId = 2, Name = "HR" },
               new Department {DepartmentId = 3, Name = "Sales" },
               new Department {DepartmentId = 4, Name = "Marketing" }
            };
        }
    }
}
