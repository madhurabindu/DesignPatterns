namespace App.Main.AbstractFactory
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
            this.btnApply = new System.Windows.Forms.Button();
            this.cmbBoxTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApply.Location = new System.Drawing.Point(37, 95);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(279, 50);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply =>";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.OnApplyButtonClicked);
            // 
            // cmbBoxTheme
            // 
            this.cmbBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBoxTheme.FormattingEnabled = true;
            this.cmbBoxTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.cmbBoxTheme.Location = new System.Drawing.Point(188, 29);
            this.cmbBoxTheme.Name = "cmbBoxTheme";
            this.cmbBoxTheme.Size = new System.Drawing.Size(121, 28);
            this.cmbBoxTheme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Theme:";
            // 
            // panelDisplay
            // 
            this.panelDisplay.Location = new System.Drawing.Point(470, 29);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(533, 449);
            this.panelDisplay.TabIndex = 3;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 510);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxTheme);
            this.Controls.Add(this.btnApply);
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmbBoxTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDisplay;
    }
}