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
            ManagelnvoicesMenuButton = new Button();
            AddInvoideMenuButton = new Button();
            pictureBox1 = new PictureBox();
            AddInvioceUserControl = new AddInvioceUserControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(ExitMenuButton);
            panel1.Controls.Add(ManagelnvoicesMenuButton);
            panel1.Controls.Add(AddInvoideMenuButton);
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
            // ManagelnvoicesMenuButton
            // 
            ManagelnvoicesMenuButton.Location = new Point(-13, 94);
            ManagelnvoicesMenuButton.Name = "ManagelnvoicesMenuButton";
            ManagelnvoicesMenuButton.Size = new Size(513, 101);
            ManagelnvoicesMenuButton.TabIndex = 1;
            ManagelnvoicesMenuButton.Text = "Manage Invoices";
            ManagelnvoicesMenuButton.UseVisualStyleBackColor = true;
            // 
            // AddInvoideMenuButton
            // 
            AddInvoideMenuButton.Location = new Point(-13, -11);
            AddInvoideMenuButton.Name = "AddInvoideMenuButton";
            AddInvoideMenuButton.Size = new Size(513, 106);
            AddInvoideMenuButton.TabIndex = 0;
            AddInvoideMenuButton.Text = "Add Invoice";
            AddInvoideMenuButton.UseVisualStyleBackColor = true;
            AddInvoideMenuButton.Click += AddInvoideMenuButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot_2025_03_28_125056;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 206);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AddInvioceUserControl
            // 
            AddInvioceUserControl.Location = new Point(494, 1);
            AddInvioceUserControl.Name = "AddInvioceUserControl";
            AddInvioceUserControl.Size = new Size(889, 1064);
            AddInvioceUserControl.TabIndex = 2;
            AddInvioceUserControl.Load += addInvioceUserControl1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_03_28_140008;
            ClientSize = new Size(1383, 1064);
            Controls.Add(AddInvioceUserControl);
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
        private Button ManagelnvoicesMenuButton;
        private Button AddInvoideMenuButton;
        private PictureBox pictureBox1;
        private Button ExitMenuButton;
        private AddInvioceUserControl AddInvioceUserControl;
    }
}
