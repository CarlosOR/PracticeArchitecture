using Microsoft.AspNetCore.Mvc;
using Practice.Architecture.Application.Interfaces.Employes;
using Practice.Architecture.Models.Dtos.Employes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Architecture.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeApplicationService _employeeService;
        public EmployeeController(IEmployeeApplicationService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        [Route(nameof(EmployeeController.Get) + "/{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_employeeService.GetEmployee(id));
        }
        
        [HttpPost]
        [Route(nameof(EmployeeController.Save) + "/{id}")]
        public ActionResult Save(DtoDataEmployee dataEmployee)
        {
            return Ok(_employeeService.SaveEmployee(dataEmployee));
        }
    }
}
