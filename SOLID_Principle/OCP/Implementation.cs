using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principle.OCP
{
    public class Implementation
    {
        public class Invoice
        {
            public virtual double GetInvoiceDiscount(double amount)
            {
                return amount - 10;
            }
        }

        public class FinalInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 50;
            }
        }
        public class ProposedInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 40;
            }
        }
        public class RecurringInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 30;
            }
        }
    }
}
