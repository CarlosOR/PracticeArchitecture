using System.Linq;
using Practice.Architecture.Models.Entities;
using Practice.Architecture.Domain.Interfaces.Users;
using Practice.Architecture.Domain.Interfaces.Employes;
using Practice.Architecture.Persistence.Interfaces.Repositories;
using Practice.Architecture.Persistence.Interfaces.Infraestructure;

namespace Practice.Architecture.Domain.Employes
{
    public class EmployeeDomainService : IEmployeeDomainService
    {
        public readonly IRepository<Employee> _repoEmployee;
        public readonly IUserDomainService _userDomainService;
        public readonly IUnitOfWork _unitOfWork;

        public EmployeeDomainService(IRepository<Employee> repository, IUserDomainService userDomainService, IUnitOfWork unitOfWork)
        {
            _repoEmployee = repository;
            _unitOfWork = unitOfWork;
            _userDomainService = userDomainService;
        }

        public Employee GetEmployeeById(int id)
        {
            return _repoEmployee.GetById(id);
        }
        
        
        public int SaveEmployee(User user, Employee employee)
        {
            int id = _userDomainService.SaveUser(user);
            employee.IdUser = id;
            _repoEmployee.Save(employee);
            _unitOfWork.Commit();
            return employee.Id;
        }

        public Employee GetEmployeeUserById(int id)
        {
            return _repoEmployee.Include("User").FirstOrDefault(e => e.Id == id);
        }


    }
}
