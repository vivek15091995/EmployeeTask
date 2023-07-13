using EmployeeRegister.Context;
using EmployeeRegister.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeRegister.BusinessLayer
{

    public class EmployeeBL
    {
        EmpEntities empEntities = new EmpEntities();

        #region Employee
        public IQueryable<EmployeeListForViewModel> GetEmployeeList()
        {
            var empList = (from emp in empEntities.EmployeeListForViews
                           select new EmployeeListForViewModel
                           {
                               EmpId = emp.EmpId,
                               EmpTag = emp.EmpTag,
                               Firstname = emp.Firstname,
                               Lastname = emp.Lastname,
                               Email = emp.Email,
                               DepartmentId = emp.DepartmentId,
                               DOB = emp.DOB,
                               Age = emp.Age,
                               DesignationId = emp.DesignationId,
                               DepartmentName = emp.DepartmentName,
                               DesignationName = emp.DesignationName
                           });
            return empList;

        }
        #endregion

        #region Departments
        public IQueryable<DepartmentModel> GetDepartments()
        {
            var depList = (from d in empEntities.Departments
                           select new DepartmentModel
                           {
                               DepartmentId = d.DepartmentId,
                               DepartmentName = d.DepartmentName
                           });
            return depList;

        }
        #endregion

        #region Designation
        public IQueryable<DesignationModel> GetDesignations()
        {
            var depList = (from d in empEntities.Designations
                           select new DesignationModel
                           {
                               DesignationId = d.DesignationId,
                               DesignationName = d.DesignationName
                           });
            return depList;

        }

        public void SaveEmployees(EmployeeModel model)
        {
            Employee employee = new Employee();
            employee.EmpId = model.EmpId;
            employee.Firstname = model.Firstname;
            employee.Lastname = model.Lastname;
            employee.EmpTag = model.EmpTag;
            employee.Email = model.Email;
            employee.DepartmentId = model.DepartmentId;
            employee.DOB = Convert.ToDateTime(model.DOB);
            employee.DesignationId = model.DesignationId;
            if (model.EmpId == 0)
            {
                empEntities.Employees.Add(employee);
            }
            else
            {
                empEntities.Entry(employee).State = EntityState.Modified;
            }

            empEntities.SaveChanges();

        }

        public void DeleteEmployee(int empId)
        {
            var employee = empEntities.Employees.FirstOrDefault(x => x.EmpId == empId);
            empEntities.Employees.Remove(employee);
            empEntities.SaveChanges();
        }
        #endregion
    }


}