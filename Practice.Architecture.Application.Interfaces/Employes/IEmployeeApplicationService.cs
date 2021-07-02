

using Practice.Architecture.Models.Dtos.Employes;

namespace Practice.Architecture.Application.Interfaces.Employes
{
    public interface IEmployeeApplicationService
    {
        DtoDataEmployee GetEmployee(int id);
        int SaveEmployee(DtoDataEmployee employee);
    }
}
