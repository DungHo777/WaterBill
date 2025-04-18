using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatewBill;

namespace WaterBill
{
    public partial class ManageInvoicesUserControl : UserControl
    {
        public ManageInvoices ListInvoices;
        public ManageInvoicesUserControl()
        {
            InitializeComponent();
        }
        public void RefreshInvoices()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("No");
            dataTable.Columns.Add("Customer ID");
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Customer Type");
            dataTable.Columns.Add("Last Month");
            dataTable.Columns.Add("This Month");
            dataTable.Columns.Add("Total");

            if (ListInvoices != null)
            {
                List<Invoice> invoices = ListInvoices.GetInvoices();
                int i = 1;
                foreach (Invoice invoice in invoices)
                {
                    dataTable.Rows.Add(
                        i++,
                        invoice.customerId,
                        invoice.customerName,
                        invoice.typeOfCustomer,
                        invoice.lastMonthNumber,
                        invoice.thisMonthNumber,
                        invoice.total

                       

                    );
                    invoicesDataGridView.DataSource = dataTable;
                }
            }
        }
    }  
}
