using System;
using static SOLID_Principle.OCP.Implementation;

namespace SOLID_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Single Responsible Principle
            Console.WriteLine("\n#-------------SR: Single Responsible Principle Violation---------------#\n");

            SOLID_Principle.SRP.Violation.UserService userService = new SOLID_Principle.SRP.Violation.UserService();
            userService.Register("ris.shohan@gmail.com","1234");
            userService.ValidateEmail("ris.shohan@gmail.com");
            userService.SendEmail("ris.shohan@gmail.com");

            Console.WriteLine("\n#-------------SR: Single Responsible Principle Implement---------------#\n");

            SOLID_Principle.SRP.Implementation.EmailService emailService = new SOLID_Principle.SRP.Implementation.EmailService();
            emailService.ValidateEmail("ris.shohan@gmail.com");
            emailService.SendEmail("ris.shohan@gmail.com");
            
            SOLID_Principle.SRP.Implementation.UserService userService1 = new SOLID_Principle.SRP.Implementation.UserService(emailService);
            userService1.Register("ris.shohan@gmail.com", "1234");

            #endregion
           
            #region Open Close Principle
            Console.WriteLine("\n#-------------OC:Open Close Principle Violation---------------#\n");

            SOLID_Principle.OCP.Violation.Invoice invoice = new SOLID_Principle.OCP.Violation.Invoice();
            Console.WriteLine(invoice.GetInvoiceDiscount(10000, SOLID_Principle.OCP.Violation.InvoiceType.ProposedInvoice));

            Console.WriteLine("\n#-------------OC:Open Close Principle Implement---------------#\n");
           
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

            Console.WriteLine(PInvoiceAmount);

            #endregion

            #region Liscov Substiution Principle
         
            Console.WriteLine("\n#-------------LS:Liscov Substiution Principle Violation---------------#\n");

            SOLID_Principle.LSP.Violation.Apple apple = new SOLID_Principle.LSP.Violation.Orange();
            Console.WriteLine("I am an apple object of {0} color",apple.GetColor());
           
            Console.WriteLine("\n#-------------LS:Liscov Substiution Principle Implementation---------------#\n");

            SOLID_Principle.LSP.Implementation.Fruit fruit = new SOLID_Principle.LSP.Implementation.Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new SOLID_Principle.LSP.Implementation.Apple();
            Console.WriteLine(fruit.GetColor());
            #endregion

            #region Interface Segregation
            Console.WriteLine("\n#-------------IS:Interface Segregation Violation---------------#\n");
            SOLID_Principle.ISP.Violation.HPLaserJetPrinter laserJetPrinter = new SOLID_Principle.ISP.Violation.HPLaserJetPrinter();
            laserJetPrinter.PrintDuplex("");
            SOLID_Principle.ISP.Violation.LiquidInkjetPrinter liquidInkjetPrinter = new SOLID_Principle.ISP.Violation.LiquidInkjetPrinter();
            liquidInkjetPrinter.PrintDuplex("");


            Console.WriteLine("\n#-------------IS:Interface Segregation Implement---------------#\n");
            SOLID_Principle.ISP.Implementation.HPLaserJetPrinter laserJetPrinter1 = new SOLID_Principle.ISP.Implementation.HPLaserJetPrinter();
            laserJetPrinter1.PrintDuplex("");
            SOLID_Principle.ISP.Implementation.LiquidInkjetPrinter liquidInkjetPrinter1 = new SOLID_Principle.ISP.Implementation.LiquidInkjetPrinter();
            liquidInkjetPrinter1.Print("");

            #endregion

            #region Dependency Inversion
            Console.WriteLine("\n#-------------DI:Dependency Inversion Violation---------------#\n");
            SOLID_Principle.DIP.Violation.EmployeeBusinessLogic obj = new SOLID_Principle.DIP.Violation.EmployeeBusinessLogic();
            var result = obj.GetEmployeeDetails(1);
            Console.WriteLine($"Id:{result.ID},\nName:{result.Name},\nDepartment:{result.Department},\nSalary:{result.Salary}");


            Console.WriteLine("\n#-------------DI:Dependency Inversion Implement---------------#\n");
            SOLID_Principle.DIP.Implementation.EmployeeBusinessLogic obj1 = new SOLID_Principle.DIP.Implementation.EmployeeBusinessLogic();
            var result1 = obj.GetEmployeeDetails(1);
            Console.WriteLine($"Id:{result1.ID},\nName:{result1.Name},\nDepartment:{result1.Department},\nSalary:{result1.Salary}");

            #endregion
        }
    }
}
