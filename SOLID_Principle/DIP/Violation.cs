using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.DIP
{
    public class Violation
    {
        // Model
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }
        //Business Logic
        public class EmployeeBusinessLogic
        {
            EmployeeDataAccess _EmployeeDataAccess;
            public EmployeeBusinessLogic()
            {
                _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
            }
            public Employee GetEmployeeDetails(int id)
            {
                return _EmployeeDataAccess.GetEmployeeDetails(id);
            }
        }
        //Data Access Factory
        public class DataAccessFactory
        {
            public static EmployeeDataAccess GetEmployeeDataAccessObj()
            {
                return new EmployeeDataAccess();
            }
        }
        //Employee Data Access
        public class EmployeeDataAccess
        {
            public Employee GetEmployeeDetails(int id)
            {
                // In real time get the employee details from db
                //but here we are hard coded the employee details
                Employee emp = new Employee()
                {
                    ID = id,
                    Name = "Pranaya",
                    Department = "IT",
                    Salary = 10000
                };
                return emp;
            }
        }
    }
}
