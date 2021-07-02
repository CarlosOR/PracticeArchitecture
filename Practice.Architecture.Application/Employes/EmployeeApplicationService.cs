using System;
using Practice.Architecture.Models.Dtos.Employes;
using Practice.Architecture.Domain.Interfaces.Employes;
using Practice.Architecture.Application.Interfaces.Employes;
using Practice.Architecture.Models.Entities;
using Practice.Architecture.Domain.Interfaces.Users;

namespace Practice.Architecture.Application.Employes
{
    public class EmployeeApplicationService : IEmployeeApplicationService
    {
        private readonly IEmployeeDomainService _employeeDomainService;
        private readonly IUserDomainService _userDomainService;
        public EmployeeApplicationService(IEmployeeDomainService employeeDomainService, IUserDomainService userDomainService)
        {
            _employeeDomainService = employeeDomainService;
            _userDomainService = userDomainService;
        }

        public DtoDataEmployee GetEmployee(int id)
        {
            Employee employee = _employeeDomainService.GetEmployeeById(id);
            User user = _userDomainService.GetUserById(employee.IdUser);

            return new DtoDataEmployee()
            {
                Id = employee.Id,
                Rol = employee.Rol,
                Salary = employee.Salary,
                Name = user.Name,
                LastName = user.LastName,
                Adress = user.LastName,
                Email = user.Email,
                Tel = user.Tel,
                BirthDate = user.BirthDate
            };
        }

        public int SaveEmployee(DtoDataEmployee dataEmployee)
        {
            Employee employee = new Employee()
            {
                Rol = "adfdaf",
                Salary = "12345",
                IdUser = 1
            };

            User user = new User()
            {
                Adress = "adsfasdf",
                BirthDate = DateTime.Now.AddYears(-20),
                Email = "fasdfasdf",
                LastName = "asdfasdf",
                Name = "fasdfasdf",
                Tel = "123342"
            };

            return _employeeDomainService.SaveEmployee(user, employee);
        }
    }
}
