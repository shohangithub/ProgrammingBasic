using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.ISP
{
    public class Violation
    {
        public interface IPrinterTasks
        {
            void Print(string PrintContent);
            void Scan(string ScanContent);
            void Fax(string FaxContent);
            void PrintDuplex(string PrintDuplexContent);
        }

        public class HPLaserJetPrinter : IPrinterTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }
            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }
            public void Fax(string FaxContent)
            {
                Console.WriteLine("Fax content");
            }
            public void PrintDuplex(string PrintDuplexContent)
            {
                Console.WriteLine("Print Duplex content");
            }
        }

        public class LiquidInkjetPrinter : IPrinterTasks
        {
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }
            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }
            public void Fax(string FaxContent)
            {
                throw new NotImplementedException();
            }
            public void PrintDuplex(string PrintDuplexContent)
            {
                Console.WriteLine(new NotImplementedException());
              //  throw new NotImplementedException();
            }
        }
    }
}
