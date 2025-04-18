using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WatewBill;

namespace WaterBill
{
     public class ManageInvoices
    {
        List<Invoice> invoices;
        public ManageInvoices()
        {
            invoices = new List<Invoice>();
        }
        public void AddInvoice(Invoice invoice)
        {
            invoices.Add(invoice);
        }
        public List<Invoice> GetInvoices()
        {
            return invoices;
        }




    }
}
