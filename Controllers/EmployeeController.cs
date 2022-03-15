using employeemanagement.aspnetcorewebapi.Model;
using employeemanagement.aspnetcorewebapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace employeemanagement.aspnetcorewebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployeesList();
                if (employees == null) return NotFound();
                return Ok(employees);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
            
        }

        [HttpGet]

        [Route("[action]/id")]
        public IActionResult SearchEmployeeByID(int id)
        {

            try
            {

                var employee = _employeeService.SearchEmployee(id);

                if (employee == null) return NotFound();

                return Ok(employee);

            }

            catch (Exception ex)
            {

                return BadRequest();
            }

        }

      



        [HttpPost]

        [Route("[action]")]
        public IActionResult SaveEmployeeByID(Employee employeeData)
        {

            try
            {

                var responseModel = _employeeService.SaveEmployee(employeeData);

                if (responseModel == null) return NotFound();

                return Ok(responseModel);

            }

            catch (Exception ex)
            {

                return BadRequest();
            }

        }



        [HttpDelete]

        [Route("[action]")]
        public IActionResult DeleteEmployeeByID(int id)
        {

            try
            {

                var employee = _employeeService.DeleteEmployee(id);

                if (employee == null) return NotFound();

                return Ok(employee);

            }

            catch (Exception ex)
            {

                return BadRequest();
            }

        }

    }
}
