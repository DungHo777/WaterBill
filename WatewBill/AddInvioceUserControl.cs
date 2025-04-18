using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterBill;

namespace WatewBill
{
    public partial class AddInvioceUserControl : UserControl
    {
        public ManageInvoices ListInvoices;
        public AddInvioceUserControl()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // check user input missing
            if (string.IsNullOrWhiteSpace(CustomerIDInput.Text) ||
      string.IsNullOrWhiteSpace(CustomerNameInput.Text) ||
      string.IsNullOrWhiteSpace(ThisMonthInput.Text) ||
      string.IsNullOrWhiteSpace(LastMonthInput.Text))
            {
                MessageBox.Show("Please fill in all required fields: Customer ID, Customer Name, This Month, and Last Month.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string CustomerID = CustomerIDInput.Text;
            string CustomerName = CustomerNameInput.Text;
            int thisMonthNumber = Convert.ToInt32(ThisMonthInput.Text);
            int lastMonthNumber = Convert.ToInt32(LastMonthInput.Text);
            string CustomerType = typeofCustomerInput.Text;
            int NumberOfPeople = Convert.ToInt32(NumberofPeople.Text);
            double price = 0;
            double VATFee = 0;
            double envFee = 0;
            double subtotal = 0;
            double total = 0;
            int amountConsumption = thisMonthNumber - lastMonthNumber;
            
            if (!int.TryParse(ThisMonthInput.Text, out thisMonthNumber) ||
!int.TryParse(LastMonthInput.Text, out lastMonthNumber))
            {
                MessageBox.Show("Invalid number format for This Month or Last Month.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (thisMonthNumber < lastMonthNumber)
            {
                MessageBox.Show("This Month's reading cannot be less than Last Month's reading.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CustomerType == "Household Customer")
            {
                double avgConsumptionPerPerson = amountConsumption / NumberOfPeople;
                if (avgConsumptionPerPerson <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                else if (avgConsumptionPerPerson <= 20)
                {
                    price = 7502;
                    envFee = 750.3;
                }
                else if (avgConsumptionPerPerson <= 30)
                {
                    price = 8699;
                    envFee = 869.9;
                }
                else
                {
                    price = 15929;
                    envFee = 1592.9;
                }

            }
            else if (CustomerType == "Administrative Agency, Public Services")
            {
                price = 9955;
                envFee = 995.5;

            }
            else if (CustomerType == "Production Units")
            {
                price = 11615;
                envFee = 1161.5;
            }
            else if (CustomerType == "Business Services")
            {
                price = 22068;
                envFee = 2206.8;
            }
            else
            {
                MessageBox.Show("Inva ilid type of customer");
                return;
            }
            subtotal = (amountConsumption * price) + envFee;
            VATFee = subtotal * 0.1;
            total = subtotal + VATFee;

            String invoiceId = DateTime.Now.ToFileTime().ToString();
            Invoice invoice = new Invoice(
                CustomerID,
                CustomerName,
                invoiceId,
                DateTime.Now,
                thisMonthNumber,
                lastMonthNumber,
                CustomerType,
                NumberOfPeople,
                amountConsumption,
                price,
                envFee,
                VATFee,
                subtotal,
                total
                );
            ListInvoices.AddInvoice(invoice);
            resultSubtotal.Text = Math.Round(subtotal, 2).ToString();
            resultEnvFee.Text = Math.Round(envFee, 2).ToString();
            resultVATFee.Text = Math.Round(VATFee, 2).ToString();
            resultTotal.Text = Math.Round(total, 2).ToString();




        }

        private void AddInvioceUserControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
