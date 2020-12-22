

namespace SOLID_Principle.DIP
{
    public class Implementation
    {
        // Model
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }
        }
        //Interface
        public interface IEmployeeDataAccess
        {
            Employee GetEmployeeDetails(int id);
        }

        //Employee Data Access
        public class EmployeeDataAccess : IEmployeeDataAccess
        {
            public Employee GetEmployeeDetails(int id)
            {
                // In real time get the employee details from db
                //but here we are hardcoded the employee details
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
       
        //Data Access Factory
        public class DataAccessFactory
        {
            public static IEmployeeDataAccess GetEmployeeDataAccessObj()
            {
                return new EmployeeDataAccess();
            }
        }

        //Business Logic
        public class EmployeeBusinessLogic
        {
            IEmployeeDataAccess _EmployeeDataAccess;
            public EmployeeBusinessLogic()
            {
                _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
            }
            public Employee GetEmployeeDetails(int id)
            {
                return _EmployeeDataAccess.GetEmployeeDetails(id);
            }
        }
    }
}
