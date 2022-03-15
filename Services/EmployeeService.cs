using employeemanagement.aspnetcorewebapi.Model;
using employeemanagement.aspnetcorewebapi.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace employeemanagement.aspnetcorewebapi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmpContext _empcontext;
        public EmployeeService(EmpContext empcontext)
        {
            _empcontext = empcontext;
        }




        public Employee SearchEmployee(int id)
        {
            Employee emp;
            try
            {
                emp = _empcontext.Find<Employee>(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return emp;
        }


        public IList<Employee> GetEmployeesList()
        {
            IList<Employee> lstemployees;
            try
            {
                lstemployees = (IList<Employee>)_empcontext.Set<Employee>().ToList();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return lstemployees;
        }

        public ResponseModel SaveEmployee(Employee employee)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                _empcontext.Add<Employee>(employee);
                _empcontext.SaveChanges();
                responseModel.IsSuccess = true;

                responseModel.Message = " Employee records saved succesfully";

            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;

                responseModel.Message = " Error:" + ex.Message;
            }
            return responseModel;
        }

        public ResponseModel DeleteEmployee(int id)
        {
            ResponseModel re= new ResponseModel();
            Employee emp=SearchEmployee(id);
            if(emp !=null)
            {
                _empcontext.Remove<Employee>(emp);
                _empcontext.SaveChanges();
                re.IsSuccess = true;
                re.Message = "Employee record deleted successfully";
            }
            else
            {
                re.IsSuccess = false;
                re.Message = "Not found";
            }
            return re;
        }

      
       
    }
}
