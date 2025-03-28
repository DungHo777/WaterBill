namespace WatewBill
{
    partial class AddInvioceUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CustomerIDInput = new TextBox();
            ThisMothInput = new TextBox();
            CustomerNameInput = new TextBox();
            LastMothInput = new TextBox();
            NumberofPeople = new TextBox();
            typeofCustomerInput = new ComboBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 72);
            label1.TabIndex = 0;
            label1.Text = "Add An Invoice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 72);
            label2.Name = "label2";
            label2.Size = new Size(233, 54);
            label2.TabIndex = 1;
            label2.Text = "CustomerID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 197);
            label3.Name = "label3";
            label3.Size = new Size(369, 54);
            label3.TabIndex = 2;
            label3.Text = "This Moth Number ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(33, 315);
            label4.Name = "label4";
            label4.Size = new Size(335, 54);
            label4.TabIndex = 3;
            label4.Text = "Type of Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(400, 72);
            label5.Name = "label5";
            label5.Size = new Size(310, 54);
            label5.TabIndex = 4;
            label5.Text = "Customer Name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(400, 197);
            label6.Name = "label6";
            label6.Size = new Size(357, 54);
            label6.TabIndex = 5;
            label6.Text = "Last Moth Number";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(402, 315);
            label7.Name = "label7";
            label7.Size = new Size(347, 54);
            label7.TabIndex = 6;
            label7.Text = "Number of People";
            label7.Click += label7_Click;
            // 
            // CustomerIDInput
            // 
            CustomerIDInput.Location = new Point(41, 129);
            CustomerIDInput.Name = "CustomerIDInput";
            CustomerIDInput.Size = new Size(286, 47);
            CustomerIDInput.TabIndex = 7;
            // 
            // ThisMothInput
            // 
            ThisMothInput.Location = new Point(41, 265);
            ThisMothInput.Name = "ThisMothInput";
            ThisMothInput.Size = new Size(286, 47);
            ThisMothInput.TabIndex = 7;
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(413, 129);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(274, 47);
            CustomerNameInput.TabIndex = 7;
            // 
            // LastMothInput
            // 
            LastMothInput.Location = new Point(413, 265);
            LastMothInput.Name = "LastMothInput";
            LastMothInput.Size = new Size(274, 47);
            LastMothInput.TabIndex = 7;
            // 
            // NumberofPeople
            // 
            NumberofPeople.Location = new Point(402, 383);
            NumberofPeople.Name = "NumberofPeople";
            NumberofPeople.Size = new Size(285, 47);
            NumberofPeople.TabIndex = 7;
            // 
            // typeofCustomerInput
            // 
            typeofCustomerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            typeofCustomerInput.FormattingEnabled = true;
            typeofCustomerInput.Items.AddRange(new object[] { "Household Customer", "Administrative Agency, Public Services", "Production Units", "Business Services" });
            typeofCustomerInput.Location = new Point(41, 381);
            typeofCustomerInput.Name = "typeofCustomerInput";
            typeofCustomerInput.Size = new Size(286, 49);
            typeofCustomerInput.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(441, 453);
            button1.Name = "button1";
            button1.Size = new Size(188, 89);
            button1.TabIndex = 9;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 477);
            label8.Name = "label8";
            label8.Size = new Size(129, 41);
            label8.TabIndex = 10;
            label8.Text = "Subtotal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 535);
            label9.Name = "label9";
            label9.Size = new Size(126, 41);
            label9.TabIndex = 10;
            label9.Text = "Evn Fee:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 587);
            label10.Name = "label10";
            label10.Size = new Size(130, 41);
            label10.TabIndex = 10;
            label10.Text = "VAT Fee:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(41, 639);
            label11.Name = "label11";
            label11.Size = new Size(96, 41);
            label11.TabIndex = 10;
            label11.Text = "Total:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(198, 477);
            label12.Name = "label12";
            label12.Size = new Size(0, 41);
            label12.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(198, 535);
            label13.Name = "label13";
            label13.Size = new Size(0, 41);
            label13.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(198, 587);
            label14.Name = "label14";
            label14.Size = new Size(0, 41);
            label14.TabIndex = 10;
            // 
            // AddInvioceUserControl
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(typeofCustomerInput);
            Controls.Add(NumberofPeople);
            Controls.Add(CustomerNameInput);
            Controls.Add(LastMothInput);
            Controls.Add(ThisMothInput);
            Controls.Add(CustomerIDInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddInvioceUserControl";
            Size = new Size(762, 707);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox CustomerIDInput;
        private TextBox ThisMothInput;
        private TextBox CustomerNameInput;
        private TextBox LastMothInput;
        private TextBox NumberofPeople;
        private ComboBox typeofCustomerInput;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
