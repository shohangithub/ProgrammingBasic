using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.ISP
{
    public class Implementation
    {
        public interface IPrinterTasks
        {
            void Print(string PrintContent);
            void Scan(string ScanContent);
        }
        public interface IFaxTasks
        {
            void Fax(string content);
        }
        public interface IPrintDuplexTasks
        {
            void PrintDuplex(string content);
        }


        public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks,
                                    IPrintDuplexTasks
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
        }
    }
}
