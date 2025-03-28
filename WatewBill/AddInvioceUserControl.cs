using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatewBill
{
    public partial class AddInvioceUserControl : UserControl
    {
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
            string CustomerID = CustomerIDInput.Text;
            string CustomerName = CustomerNameInput.Text;
            int thisMothNumber = Convert.ToInt32(ThisMothInput.Text);
            int lastMothNumber = Convert.ToInt32(LastMothInput.Text);
            string CustomerType = typeofCustomerInput.Text;
            int NumberOfPeople = Convert.ToInt32(NumberofPeople.Text);
            double price = 0;
            double VATFee = 0;
            double envFee = 0;
            double subtotal = 0;
            double total = 0;
            int amountConsumption = thisMothNumber - lastMothNumber;
            if (CustomerType == "Household customer")
            {

            }
            else if (CustomerType == "Administrative agency, public services")
            {
                price = 9955;
                envFee = 995.5;

            }
            else if (CustomerType == "production unit")
            {
                price = 11615;
                envFee = 1161.5;
            }
            else if (CustomerType == "Business services")
            {
                price = 22068;
                envFee = 2206.8; 
            }
            else 
            {
                MessageBox.Show("Invailid type of customer");
                return;
            } 
            subtotal = ( amountConsumption * price) + envFee;
            VATFee = subtotal * 0.1;
            total = subtotal + VATFee;

            String invoiceId = DateTime.Now.ToFileTime().ToString();
            Invoice invoice = new Invoice(
                CustomerID,
                CustomerName,
                invoiceId,
                DateTime.Now,
                thisMothNumber,
                lastMothNumber,
                CustomerType,
                NumberOfPeople,
                amountConsumption,
                price,
                envFee,
                VATFee,
                subtotal,
                total
                );
            resultSbtotal 




        }
    }
}
