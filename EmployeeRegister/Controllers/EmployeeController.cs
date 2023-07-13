using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using EmployeeRegister.Helper;
using EmployeeRegister.Models;

namespace EmployeeRegister.Controllers
{
    public class EmployeeController : Controller
    {
        #region Declarations
        EmployeeHelper helper = new EmployeeHelper();
        #endregion

        // GET: Employee
        public ActionResult Employee()
        {
            var departments = helper.GetDepartments();
            var designations = helper.GetDesignation();
            if (departments.Any() && designations.Any())
            {
                ViewBag.departments = departments;
                ViewBag.designations = designations;
            }

            return View();

        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel model)
        {

            if (ModelState.IsValid)
            {
                helper.SaveEmployee(model);
            }

            ModelState.Clear();
            var departments = helper.GetDepartments();
            var designations = helper.GetDesignation();

            if (departments.Any() && designations.Any())
            {
                ViewBag.departments = departments;
                ViewBag.designations = designations;
            }
            return View("Employee");
        }
        public ActionResult EmployeeList(string sortOrder, string CurrentSort, int? page)
        {
            var empList = helper.GetEmployeeList();
            return View(empList);
        }

        public ActionResult DeleteEmployee(int empId)
        {
            helper.DeleteEmployee(empId);
            var empList = helper.GetEmployeeList();
            return View("EmployeeList", empList);
        }


        public ActionResult UpdateEmployee(EmployeeModel model)
        {
            var departments = helper.GetDepartments();
            var designations = helper.GetDesignation();

            if (departments.Any() && designations.Any())
            {
                ViewBag.departments = departments;
                ViewBag.designations = designations;
            }
            return View("Employee", model);
        }
    }


}