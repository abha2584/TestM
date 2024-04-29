using WebApi.Models;

namespace WebApi.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> AllEmployees()
        {
            return new List<Employee>()
            {
                new Employee {Id = 1, FirstName ="John", LastName = "Doe", Salary = 100000,  HireDate = DateTime.Now.AddMonths(-5) },
                new Employee {Id = 2, FirstName ="Dean", LastName = "Smith", Salary = 120000, HireDate = DateTime.Now.AddDays(-5)},
                new Employee {Id = 3, FirstName ="Jeff", LastName = "Stricklin", Salary = 130000, HireDate = DateTime.Now.AddMonths(-3) },
                new Employee {Id = 4, FirstName ="Brad", LastName = "Johnson", Salary = 50000,  HireDate = DateTime.Now.AddMonths(-1) },
                new Employee {Id = 5, FirstName ="Manoj", LastName = "Tiwari", Salary = 200000, HireDate = DateTime.Now.AddDays(-12)},
                new Employee {Id = 6, FirstName ="Doug", LastName = "Johns", Salary = 125000,HireDate = DateTime.Now.AddMonths(-7) },
                new Employee {Id = 7, FirstName ="Scott", LastName = "Clark", Salary = 100000, HireDate = DateTime.Now.AddDays(-5)},
                new Employee {Id = 8, FirstName ="Michael", LastName = "Clark", Salary = 100000,  HireDate = DateTime.Now.AddMonths(-9)},
                new Employee {Id = 9, FirstName ="Johnson", LastName = "Doe", Salary = 100000,  HireDate = DateTime.Now.AddDays(-15)},
            };
        }

    }
}
