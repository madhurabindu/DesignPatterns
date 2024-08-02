namespace App.Main.Prototype
{
    partial class MainApp
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxGender = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromAddr1 = new System.Windows.Forms.TextBox();
            this.txtFromAddr2 = new System.Windows.Forms.TextBox();
            this.txtFromAddr3 = new System.Windows.Forms.TextBox();
            this.txtToAddr3 = new System.Windows.Forms.TextBox();
            this.txtToAddr2 = new System.Windows.Forms.TextBox();
            this.txtToAddr1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.bnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.Location = new System.Drawing.Point(539, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(725, 648);
            this.webBrowser1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // txtFromName
            // 
            this.txtFromName.Location = new System.Drawing.Point(130, 121);
            this.txtFromName.Name = "txtFromName";
            this.txtFromName.Size = new System.Drawing.Size(214, 22);
            this.txtFromName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // txtToName
            // 
            this.txtToName.Location = new System.Drawing.Point(130, 285);
            this.txtToName.Name = "txtToName";
            this.txtToName.Size = new System.Drawing.Size(214, 22);
            this.txtToName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender:";
            // 
            // listBoxGender
            // 
            this.listBoxGender.FormattingEnabled = true;
            this.listBoxGender.ItemHeight = 16;
            this.listBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.listBoxGender.Location = new System.Drawing.Point(386, 285);
            this.listBoxGender.Name = "listBoxGender";
            this.listBoxGender.Size = new System.Drawing.Size(75, 52);
            this.listBoxGender.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "From Address:";
            // 
            // txtFromAddr1
            // 
            this.txtFromAddr1.Location = new System.Drawing.Point(130, 166);
            this.txtFromAddr1.Name = "txtFromAddr1";
            this.txtFromAddr1.Size = new System.Drawing.Size(214, 22);
            this.txtFromAddr1.TabIndex = 2;
            // 
            // txtFromAddr2
            // 
            this.txtFromAddr2.Location = new System.Drawing.Point(130, 188);
            this.txtFromAddr2.Name = "txtFromAddr2";
            this.txtFromAddr2.Size = new System.Drawing.Size(214, 22);
            this.txtFromAddr2.TabIndex = 3;
            // 
            // txtFromAddr3
            // 
            this.txtFromAddr3.Location = new System.Drawing.Point(130, 210);
            this.txtFromAddr3.Name = "txtFromAddr3";
            this.txtFromAddr3.Size = new System.Drawing.Size(214, 22);
            this.txtFromAddr3.TabIndex = 4;
            // 
            // txtToAddr3
            // 
            this.txtToAddr3.Location = new System.Drawing.Point(130, 374);
            this.txtToAddr3.Name = "txtToAddr3";
            this.txtToAddr3.Size = new System.Drawing.Size(214, 22);
            this.txtToAddr3.TabIndex = 9;
            // 
            // txtToAddr2
            // 
            this.txtToAddr2.Location = new System.Drawing.Point(130, 352);
            this.txtToAddr2.Name = "txtToAddr2";
            this.txtToAddr2.Size = new System.Drawing.Size(214, 22);
            this.txtToAddr2.TabIndex = 8;
            // 
            // txtToAddr1
            // 
            this.txtToAddr1.Location = new System.Drawing.Point(130, 330);
            this.txtToAddr1.Name = "txtToAddr1";
            this.txtToAddr1.Size = new System.Drawing.Size(214, 22);
            this.txtToAddr1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "To Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Type of Letter:";
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Items.AddRange(new object[] {
            "Offer Letter",
            "Promotion Letter",
            "Experience Letter",
            "Employment Verification Letter",
            "Termination Letter"});
            this.cmbBoxType.Location = new System.Drawing.Point(130, 36);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(214, 24);
            this.cmbBoxType.TabIndex = 0;
            this.cmbBoxType.SelectedIndexChanged += new System.EventHandler(this.OnLetterTypeSelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(141, 441);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(154, 41);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate Letter";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.OnGenerateButtonClicked);
            // 
            // bnPrint
            // 
            this.bnPrint.Location = new System.Drawing.Point(333, 599);
            this.bnPrint.Name = "bnPrint";
            this.bnPrint.Size = new System.Drawing.Size(154, 41);
            this.bnPrint.TabIndex = 17;
            this.bnPrint.Text = "Print Letter";
            this.bnPrint.UseVisualStyleBackColor = true;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 648);
            this.Controls.Add(this.bnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbBoxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtToAddr3);
            this.Controls.Add(this.txtToAddr2);
            this.Controls.Add(this.txtToAddr1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFromAddr3);
            this.Controls.Add(this.txtFromAddr2);
            this.Controls.Add(this.txtFromAddr1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFromName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "MainApp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromAddr1;
        private System.Windows.Forms.TextBox txtFromAddr2;
        private System.Windows.Forms.TextBox txtFromAddr3;
        private System.Windows.Forms.TextBox txtToAddr3;
        private System.Windows.Forms.TextBox txtToAddr2;
        private System.Windows.Forms.TextBox txtToAddr1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button bnPrint;
    }
}

