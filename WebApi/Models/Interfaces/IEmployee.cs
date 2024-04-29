
namespace WebApi.Models.Interfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime HireDate { get; set; }
        decimal Salary { get; set; }
    }
}
