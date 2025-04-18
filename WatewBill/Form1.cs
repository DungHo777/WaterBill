using WaterBill;

namespace WatewBill
{
    public partial class Form1 : Form
    {
        public ManageInvoices FormListInvoices = new ManageInvoices();
        public Form1()
        {
            InitializeComponent();
            AddInvoiceUserControl.Hide();
            manageInvoicesUserControl.Hide();

            AddInvoiceUserControl.ListInvoices = FormListInvoices;
            manageInvoicesUserControl.ListInvoices = FormListInvoices;
        }

        private void addInvioceUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void ExitMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddInvoideMenuButton_Click(object sender, EventArgs e)
        {
            AddInvoiceUserControl.Show();
            manageInvoicesUserControl.Hide();

            AddInvoiceMenuButton.BackColor = Color.DarkGray;
            AddInvoiceMenuButton.ForeColor = Color.White;

            ManageInvoicesMenuButton.BackColor = Color.White;
            ManageInvoicesMenuButton.ForeColor = Color.Black;
        }

        private void manageInvoicesUserControl1_Load(object sender, EventArgs e)
        {


        }

        private void ManagelnvoicesMenuButton_Click(object sender, EventArgs e)
        {
            AddInvoiceUserControl.Hide();
            manageInvoicesUserControl.RefreshInvoices();
            manageInvoicesUserControl.Show();

            AddInvoiceMenuButton.BackColor = Color.White;
            AddInvoiceMenuButton.ForeColor = Color.Black;

            ManageInvoicesMenuButton.BackColor = Color.DarkGray;
            ManageInvoicesMenuButton.ForeColor = Color.White;
        }
    }
}
