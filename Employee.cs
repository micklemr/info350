/* Employee.cs
 * Data members are employee number, name, 
 * date of hire, and monthly salary. 
 * Properties are defined for each data
 * member. The ToSring( ) method of the
 * object class is overridden.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Employee
    {
        private int employeeNumber;
        private string employeeName;
        private string dateOfHire;
        private double salary;

        public Employee()
        {
        }

        public Employee(int empNo)
        {
            employeeNumber = empNo;
        }

        public Employee(int empNo, string empName, string hireDate)
        {
            employeeNumber = empNo;
            employeeName = empName;
            dateOfHire = hireDate;
        }
        public Employee(int empNo, string empName, string hireDate, double newSalary)
        {
            employeeNumber = empNo;
            employeeName = empName;
            dateOfHire = hireDate;
            salary = newSalary;
        }

        public int EmployeeNumber
        {
            get
            {
                return employeeNumber;
            }
            set
            {
                employeeNumber = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }

        public string DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                dateOfHire = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;

            }
            set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return "Employee Name: " +
                    employeeName +
                    "\nEmployee Number: " +
                    employeeNumber +
                    "\nDate of Hire: " +
                    dateOfHire +
                    "\nSalary: " +
                    salary.ToString("c");
        }
    }
}
