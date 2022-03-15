using employeemanagement.aspnetcorewebapi.Model;
using employeemanagement.aspnetcorewebapi.View_Models;
using System.Collections.Generic;

namespace employeemanagement.aspnetcorewebapi.Services
{
    public interface  IEmployeeService
    {
        IList<Employee> GetEmployeesList();

        Employee SearchEmployee(int id);

        ResponseModel SaveEmployee(Employee employee);

        ResponseModel DeleteEmployee(int id);

    }
}
