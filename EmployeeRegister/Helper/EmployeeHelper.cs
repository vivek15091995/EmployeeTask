using EmployeeRegister.Models;
using EmployeeRegister.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRegister.Helper
{
    public class EmployeeHelper
    {
        EmployeeBL employeeBL = new EmployeeBL();
        public List<EmployeeListForViewModel> GetEmployeeList()
        {
            return employeeBL.GetEmployeeList().ToList();
        }

        public List<DepartmentModel> GetDepartments()
        {
            return employeeBL.GetDepartments().ToList();
        }
        public List<DesignationModel> GetDesignation()
        {
            return employeeBL.GetDesignations().ToList();
        }

        public void SaveEmployee(EmployeeModel model)
        {
            employeeBL.SaveEmployees(model);
        }
        public void DeleteEmployee(int empId)
        {
            employeeBL.DeleteEmployee(empId);
        }
    }

    
}