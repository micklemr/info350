/* EmployeeApp.cs
 * This class tests the Employee class,
 * calling constructor methods to instantiate
 * objects, using properties to set values and
 * displaying object's data through invoking the
 * ToString( ) method. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class EmployeeApp
    {
        static void Main(string[] args)
        {
            Employee firstEmployeeObject = new Employee();
            firstEmployeeObject.EmployeeName = AskForEmployeeName();
            firstEmployeeObject.EmployeeNumber = AskForEmployeeNumber();
            firstEmployeeObject.DateOfHire =
                AskForDateOfHire(firstEmployeeObject.EmployeeName);
            firstEmployeeObject.Salary = AskForSalary();
            
            Console.Clear();
            Console.WriteLine("First Employee");
            Console.WriteLine(firstEmployeeObject.ToString());

            Employee secondEmployeeObject = new Employee(2345);
            secondEmployeeObject.Salary = 95000;
            
            Console.WriteLine("\n\nSecond Employee");
            Console.WriteLine("Employee Number: " + secondEmployeeObject.EmployeeNumber +
                               "\nSalary: {0:c}", secondEmployeeObject.Salary);

            Employee thirdEmployeeObject = new Employee(2234, "Timothy Walnut", "01/01/2009");
            thirdEmployeeObject.Salary = 75000;
            Console.WriteLine("\n\nThird Employee");
            Console.WriteLine(thirdEmployeeObject);

            Employee lastEmployeeObject = new Employee(1234, "Maria Smith", "01/01/2008", 60000);
            Console.WriteLine("\n\nLast Employee");
            Console.WriteLine("Employee Name: " + lastEmployeeObject.EmployeeName +
                              "\nEmployee Number: " + lastEmployeeObject.EmployeeNumber +
                              "\nDateOfHire: " + lastEmployeeObject.DateOfHire +
                              "\nSalary: " + lastEmployeeObject.Salary.ToString("c"));
            Console.ReadKey();
        }

        public static double AskForSalary()
        {
            string inValue;
            double theSalary;
            Console.Write("Enter salary amount: ");
            inValue = Console.ReadLine();
            theSalary = double.Parse(inValue);
            return theSalary;
        }

        public static string AskForEmployeeName()
        {
            string inValue;
            Console.Write("Enter Employee Name: ");
            inValue = Console.ReadLine();
            return inValue;
        }
        public static string AskForDateOfHire(string name)
        {
            string inValue;
            Console.Write("Enter {0}\'s Date Of Hire: ", name);
            inValue = Console.ReadLine();
            return inValue;
        }
        public static int AskForEmployeeNumber()
        {
            string inValue;
            Console.Write("Enter Employee Number: ");
            inValue = Console.ReadLine();
            return(int.Parse(inValue));
        }
    }
 }
