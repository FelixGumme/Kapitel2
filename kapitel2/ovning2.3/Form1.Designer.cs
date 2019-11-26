namespace ovning2._3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPersonNr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbxRäntesats = new System.Windows.Forms.TextBox();
            this.tbxKredit = new System.Windows.Forms.TextBox();
            this.btnIntättning = new System.Windows.Forms.Button();
            this.btnUttag = new System.Windows.Forms.Button();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.lbxKonto = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUttag);
            this.groupBox1.Controls.Add(this.btnIntättning);
            this.groupBox1.Controls.Add(this.tbxBelopp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insättning/ Uttag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrera);
            this.groupBox2.Controls.Add(this.tbxKredit);
            this.groupBox2.Controls.Add(this.tbxRäntesats);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxPersonNr);
            this.groupBox2.Location = new System.Drawing.Point(307, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öppna konto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belopp";
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.AutoSize = true;
            this.tbxPersonNr.Location = new System.Drawing.Point(19, 50);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(51, 13);
            this.tbxPersonNr.TabIndex = 1;
            this.tbxPersonNr.Text = "PersonNr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Räntesats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kredit";
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(110, 47);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(142, 20);
            this.tbxBelopp.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 2;
            // 
            // tbxRäntesats
            // 
            this.tbxRäntesats.Location = new System.Drawing.Point(78, 89);
            this.tbxRäntesats.Name = "tbxRäntesats";
            this.tbxRäntesats.Size = new System.Drawing.Size(142, 20);
            this.tbxRäntesats.TabIndex = 4;
            // 
            // tbxKredit
            // 
            this.tbxKredit.Location = new System.Drawing.Point(78, 126);
            this.tbxKredit.Name = "tbxKredit";
            this.tbxKredit.Size = new System.Drawing.Size(142, 20);
            this.tbxKredit.TabIndex = 5;
            // 
            // btnIntättning
            // 
            this.btnIntättning.Location = new System.Drawing.Point(139, 152);
            this.btnIntättning.Name = "btnIntättning";
            this.btnIntättning.Size = new System.Drawing.Size(113, 22);
            this.btnIntättning.TabIndex = 2;
            this.btnIntättning.Text = "Insättning";
            this.btnIntättning.UseVisualStyleBackColor = true;
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(139, 194);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(113, 21);
            this.btnUttag.TabIndex = 3;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(130, 194);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(120, 22);
            this.btnRegistrera.TabIndex = 4;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(607, 233);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(244, 27);
            this.btnUppdatera.TabIndex = 6;
            this.btnUppdatera.Text = "Uppdatera med årsränta";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            // 
            // lbxKonto
            // 
            this.lbxKonto.FormattingEnabled = true;
            this.lbxKonto.Location = new System.Drawing.Point(607, 37);
            this.lbxKonto.Name = "lbxKonto";
            this.lbxKonto.Size = new System.Drawing.Size(244, 173);
            this.lbxKonto.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 272);
            this.Controls.Add(this.lbxKonto);
            this.Controls.Add(this.btnUppdatera);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.Button btnIntättning;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.TextBox tbxKredit;
        private System.Windows.Forms.TextBox tbxRäntesats;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbxPersonNr;
        private System.Windows.Forms.Button btnUppdatera;
        private System.Windows.Forms.ListBox lbxKonto;
    }
}

