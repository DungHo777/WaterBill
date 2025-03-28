namespace WatewBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddInvioceUserControl.Hide();
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
            AddInvioceUserControl.Show();
            AddInvoideMenuButton.BackColor = Color.DarkGray;

        }
    }
}
