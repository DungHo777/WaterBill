namespace WatewBill
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ExitMenuButton = new Button();
            ManageInvoicesMenuButton = new Button();
            AddInvoiceMenuButton = new Button();
            pictureBox1 = new PictureBox();
            AddInvoiceUserControl = new AddInvioceUserControl();
            manageInvoicesUserControl = new WaterBill.ManageInvoicesUserControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(ExitMenuButton);
            panel1.Controls.Add(ManageInvoicesMenuButton);
            panel1.Controls.Add(AddInvoiceMenuButton);
            panel1.Location = new Point(0, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 898);
            panel1.TabIndex = 0;
            // 
            // ExitMenuButton
            // 
            ExitMenuButton.Location = new Point(0, 824);
            ExitMenuButton.Name = "ExitMenuButton";
            ExitMenuButton.Size = new Size(503, 74);
            ExitMenuButton.TabIndex = 2;
            ExitMenuButton.Text = "Exit";
            ExitMenuButton.UseVisualStyleBackColor = true;
            ExitMenuButton.Click += ExitMenuButton_Click;
            // 
            // ManageInvoicesMenuButton
            // 
            ManageInvoicesMenuButton.Location = new Point(0, 90);
            ManageInvoicesMenuButton.Name = "ManageInvoicesMenuButton";
            ManageInvoicesMenuButton.Size = new Size(513, 101);
            ManageInvoicesMenuButton.TabIndex = 1;
            ManageInvoicesMenuButton.Text = "Manage Invoices";
            ManageInvoicesMenuButton.UseVisualStyleBackColor = true;
            ManageInvoicesMenuButton.Click += ManagelnvoicesMenuButton_Click;
            // 
            // AddInvoiceMenuButton
            // 
            AddInvoiceMenuButton.Location = new Point(-13, -11);
            AddInvoiceMenuButton.Name = "AddInvoiceMenuButton";
            AddInvoiceMenuButton.Size = new Size(513, 106);
            AddInvoiceMenuButton.TabIndex = 0;
            AddInvoiceMenuButton.Text = "Add Invoice";
            AddInvoiceMenuButton.UseVisualStyleBackColor = true;
            AddInvoiceMenuButton.Click += AddInvoideMenuButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = WaterBill.Properties.Resources.Screenshot_2025_03_28_125056;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 206);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AddInvoiceUserControl
            // 
            AddInvoiceUserControl.Location = new Point(494, 1);
            AddInvoiceUserControl.Name = "AddInvoiceUserControl";
            AddInvoiceUserControl.Size = new Size(877, 1064);
            AddInvoiceUserControl.TabIndex = 2;
            AddInvoiceUserControl.Load += addInvioceUserControl1_Load;
            // 
            // manageInvoicesUserControl
            // 
            manageInvoicesUserControl.Location = new Point(483, 75);
            manageInvoicesUserControl.Name = "manageInvoicesUserControl";
            manageInvoicesUserControl.Size = new Size(1782, 931);
            manageInvoicesUserControl.TabIndex = 3;
            manageInvoicesUserControl.Load += manageInvoicesUserControl1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2263, 1064);
            Controls.Add(manageInvoicesUserControl);
            Controls.Add(AddInvoiceUserControl);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ManageInvoicesMenuButton;
        private Button AddInvoiceMenuButton;
        private PictureBox pictureBox1;
        private Button ExitMenuButton;
        private AddInvioceUserControl AddInvoiceUserControl;
        private WaterBill.ManageInvoicesUserControl manageInvoicesUserControl;
    }
}
