namespace ovning2._2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Säljare = new System.Windows.Forms.GroupBox();
            this.tbxSellerSale = new System.Windows.Forms.TextBox();
            this.tbxProvision = new System.Windows.Forms.TextBox();
            this.tbxSellerName = new System.Windows.Forms.TextBox();
            this.btnRegisterSale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxConsultantName = new System.Windows.Forms.TextBox();
            this.tbxHourlySalary = new System.Windows.Forms.TextBox();
            this.tbxTimeWorked = new System.Windows.Forms.TextBox();
            this.btnRegisterWorkpass = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxMonthlySalary = new System.Windows.Forms.TextBox();
            this.tbxOfficeWorkerName = new System.Windows.Forms.TextBox();
            this.btnMonthlySalary = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbxRegister = new System.Windows.Forms.ListBox();
            this.lbxSalaryPayment = new System.Windows.Forms.ListBox();
            this.tbxTotalSalary = new System.Windows.Forms.TextBox();
            this.btnTotalSalary = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Säljare.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Säljare
            // 
            this.Säljare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Säljare.Controls.Add(this.tbxSellerSale);
            this.Säljare.Controls.Add(this.tbxProvision);
            this.Säljare.Controls.Add(this.tbxSellerName);
            this.Säljare.Controls.Add(this.btnRegisterSale);
            this.Säljare.Controls.Add(this.label3);
            this.Säljare.Controls.Add(this.label2);
            this.Säljare.Controls.Add(this.label1);
            this.Säljare.Location = new System.Drawing.Point(12, 12);
            this.Säljare.Name = "Säljare";
            this.Säljare.Size = new System.Drawing.Size(171, 193);
            this.Säljare.TabIndex = 0;
            this.Säljare.TabStop = false;
            this.Säljare.Text = "Säljare";
            // 
            // tbxSellerSale
            // 
            this.tbxSellerSale.Location = new System.Drawing.Point(75, 110);
            this.tbxSellerSale.Name = "tbxSellerSale";
            this.tbxSellerSale.Size = new System.Drawing.Size(85, 20);
            this.tbxSellerSale.TabIndex = 16;
            // 
            // tbxProvision
            // 
            this.tbxProvision.Location = new System.Drawing.Point(75, 72);
            this.tbxProvision.Name = "tbxProvision";
            this.tbxProvision.Size = new System.Drawing.Size(85, 20);
            this.tbxProvision.TabIndex = 15;
            // 
            // tbxSellerName
            // 
            this.tbxSellerName.Location = new System.Drawing.Point(75, 30);
            this.tbxSellerName.Name = "tbxSellerName";
            this.tbxSellerName.Size = new System.Drawing.Size(85, 20);
            this.tbxSellerName.TabIndex = 14;
            // 
            // btnRegisterSale
            // 
            this.btnRegisterSale.Location = new System.Drawing.Point(15, 157);
            this.btnRegisterSale.Name = "btnRegisterSale";
            this.btnRegisterSale.Size = new System.Drawing.Size(136, 23);
            this.btnRegisterSale.TabIndex = 3;
            this.btnRegisterSale.Text = "Registrere försäljning";
            this.btnRegisterSale.UseVisualStyleBackColor = true;
            this.btnRegisterSale.Click += new System.EventHandler(this.BtnRegisterSale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Försäljning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.tbxConsultantName);
            this.groupBox2.Controls.Add(this.tbxHourlySalary);
            this.groupBox2.Controls.Add(this.tbxTimeWorked);
            this.groupBox2.Controls.Add(this.btnRegisterWorkpass);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(189, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konsult";
            // 
            // tbxConsultantName
            // 
            this.tbxConsultantName.Location = new System.Drawing.Point(80, 33);
            this.tbxConsultantName.Name = "tbxConsultantName";
            this.tbxConsultantName.Size = new System.Drawing.Size(85, 20);
            this.tbxConsultantName.TabIndex = 17;
            // 
            // tbxHourlySalary
            // 
            this.tbxHourlySalary.Location = new System.Drawing.Point(80, 72);
            this.tbxHourlySalary.Name = "tbxHourlySalary";
            this.tbxHourlySalary.Size = new System.Drawing.Size(85, 20);
            this.tbxHourlySalary.TabIndex = 18;
            // 
            // tbxTimeWorked
            // 
            this.tbxTimeWorked.Location = new System.Drawing.Point(80, 110);
            this.tbxTimeWorked.Name = "tbxTimeWorked";
            this.tbxTimeWorked.Size = new System.Drawing.Size(85, 20);
            this.tbxTimeWorked.TabIndex = 19;
            // 
            // btnRegisterWorkpass
            // 
            this.btnRegisterWorkpass.Location = new System.Drawing.Point(16, 157);
            this.btnRegisterWorkpass.Name = "btnRegisterWorkpass";
            this.btnRegisterWorkpass.Size = new System.Drawing.Size(136, 23);
            this.btnRegisterWorkpass.TabIndex = 4;
            this.btnRegisterWorkpass.Text = "Registrera arbetspass";
            this.btnRegisterWorkpass.UseVisualStyleBackColor = true;
            this.btnRegisterWorkpass.Click += new System.EventHandler(this.BtnRegisterWorkpass_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Arbetad tid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timlön";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Namn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.tbxMonthlySalary);
            this.groupBox3.Controls.Add(this.tbxOfficeWorkerName);
            this.groupBox3.Controls.Add(this.btnMonthlySalary);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(366, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 193);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontorist";
            // 
            // tbxMonthlySalary
            // 
            this.tbxMonthlySalary.Location = new System.Drawing.Point(76, 73);
            this.tbxMonthlySalary.Name = "tbxMonthlySalary";
            this.tbxMonthlySalary.Size = new System.Drawing.Size(85, 20);
            this.tbxMonthlySalary.TabIndex = 21;
            // 
            // tbxOfficeWorkerName
            // 
            this.tbxOfficeWorkerName.Location = new System.Drawing.Point(76, 33);
            this.tbxOfficeWorkerName.Name = "tbxOfficeWorkerName";
            this.tbxOfficeWorkerName.Size = new System.Drawing.Size(85, 20);
            this.tbxOfficeWorkerName.TabIndex = 20;
            // 
            // btnMonthlySalary
            // 
            this.btnMonthlySalary.Location = new System.Drawing.Point(17, 157);
            this.btnMonthlySalary.Name = "btnMonthlySalary";
            this.btnMonthlySalary.Size = new System.Drawing.Size(136, 23);
            this.btnMonthlySalary.TabIndex = 6;
            this.btnMonthlySalary.Text = "Registrera månadslön";
            this.btnMonthlySalary.UseVisualStyleBackColor = true;
            this.btnMonthlySalary.Click += new System.EventHandler(this.BtnMonthlySalary_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Månadslön";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Namn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Register";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Löneutbetalningar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(383, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Totala lönekostnader";
            // 
            // lbxRegister
            // 
            this.lbxRegister.FormattingEnabled = true;
            this.lbxRegister.Location = new System.Drawing.Point(27, 244);
            this.lbxRegister.Name = "lbxRegister";
            this.lbxRegister.Size = new System.Drawing.Size(163, 134);
            this.lbxRegister.TabIndex = 11;
            // 
            // lbxSalaryPayment
            // 
            this.lbxSalaryPayment.FormattingEnabled = true;
            this.lbxSalaryPayment.Location = new System.Drawing.Point(215, 244);
            this.lbxSalaryPayment.Name = "lbxSalaryPayment";
            this.lbxSalaryPayment.Size = new System.Drawing.Size(162, 134);
            this.lbxSalaryPayment.TabIndex = 12;
            // 
            // tbxTotalSalary
            // 
            this.tbxTotalSalary.Location = new System.Drawing.Point(387, 312);
            this.tbxTotalSalary.Name = "tbxTotalSalary";
            this.tbxTotalSalary.Size = new System.Drawing.Size(132, 20);
            this.tbxTotalSalary.TabIndex = 13;
            // 
            // btnTotalSalary
            // 
            this.btnTotalSalary.Location = new System.Drawing.Point(383, 244);
            this.btnTotalSalary.Name = "btnTotalSalary";
            this.btnTotalSalary.Size = new System.Drawing.Size(136, 23);
            this.btnTotalSalary.TabIndex = 8;
            this.btnTotalSalary.Text = "Beräkna löner";
            this.btnTotalSalary.UseVisualStyleBackColor = true;
            this.btnTotalSalary.Click += new System.EventHandler(this.BtnTotalSalary_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(27, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 22);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Ta bort en person";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 418);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTotalSalary);
            this.Controls.Add(this.tbxTotalSalary);
            this.Controls.Add(this.lbxSalaryPayment);
            this.Controls.Add(this.lbxRegister);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Säljare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Säljare.ResumeLayout(false);
            this.Säljare.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Säljare;
        private System.Windows.Forms.TextBox tbxProvision;
        private System.Windows.Forms.TextBox tbxSellerName;
        private System.Windows.Forms.Button btnRegisterSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxConsultantName;
        private System.Windows.Forms.TextBox tbxHourlySalary;
        private System.Windows.Forms.TextBox tbxTimeWorked;
        private System.Windows.Forms.Button btnRegisterWorkpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxMonthlySalary;
        private System.Windows.Forms.TextBox tbxOfficeWorkerName;
        private System.Windows.Forms.Button btnMonthlySalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbxRegister;
        private System.Windows.Forms.ListBox lbxSalaryPayment;
        private System.Windows.Forms.TextBox tbxTotalSalary;
        private System.Windows.Forms.Button btnTotalSalary;
        private System.Windows.Forms.TextBox tbxSellerSale;
        private System.Windows.Forms.Button btnDelete;
    }
}

