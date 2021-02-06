using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalSV.Models
{
    public class LeaveWithSalaryModel
    {
        public string EmployeeCode { get; set; }
        public DateTime AttendanceDate { get; set; }
        public double SalaryRate { get; set; }
        public string Remarks { get; set; }
    }
}
