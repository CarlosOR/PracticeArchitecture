using Practice.Architecture.Models.Entities;

namespace Practice.Architecture.Domain.Interfaces.Employes
{
    public interface IEmployeeDomainService
    {
        int SaveEmployee(User user, Employee employee);
        Employee GetEmployeeById(int id);
        Employee GetEmployeeUserById(int id);
    }
}
