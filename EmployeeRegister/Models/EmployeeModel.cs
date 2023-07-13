using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeRegister.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage = "Please Enter Employee Tag")]
        public string EmpTag { get; set; }
        [Required(ErrorMessage = "Please Enter Firstname")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Please Enter Lastname")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter Valid email")]
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please Enter Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime DOB { get; set; }
        public int DesignationId { get; set; }



    }

    public class DepartmentModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
    public class DesignationModel
    {
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
    }
    public partial class EmployeeListForViewModel
    {
        public int EmpId { get; set; }
        public string EmpTag { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime DOB { get; set; }
        public int DesignationId { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
        public Nullable<int> Age { get; set; }
    }
}