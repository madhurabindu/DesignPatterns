namespace TestAppForControls
{
    partial class TestApp
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
            this.lightActionButton1 = new GUIControls.LightTheme.LightActionButton();
            this.lightImageButton1 = new GUIControls.LightTheme.LightImageButton();
            this.lightCenteredLabel1 = new GUIControls.LightTheme.LightCenteredLabel();
            this.SuspendLayout();
            // 
            // lightActionButton1
            // 
            this.lightActionButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lightActionButton1.Font = new System.Drawing.Font("Calibri", 10F);
            this.lightActionButton1.Location = new System.Drawing.Point(37, 123);
            this.lightActionButton1.Name = "lightActionButton1";
            this.lightActionButton1.Size = new System.Drawing.Size(140, 40);
            this.lightActionButton1.TabIndex = 0;
            this.lightActionButton1.Text = "lightActionButton1";
            this.lightActionButton1.UseVisualStyleBackColor = false;
            // 
            // lightImageButton1
            // 
            this.lightImageButton1.Location = new System.Drawing.Point(103, 200);
            this.lightImageButton1.Name = "lightImageButton1";
            this.lightImageButton1.Size = new System.Drawing.Size(150, 150);
            this.lightImageButton1.TabIndex = 2;
            // 
            // lightCenteredLabel1
            // 
            this.lightCenteredLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lightCenteredLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightCenteredLabel1.Font = new System.Drawing.Font("Calibri", 10F);
            this.lightCenteredLabel1.Location = new System.Drawing.Point(389, 101);
            this.lightCenteredLabel1.Name = "lightCenteredLabel1";
            this.lightCenteredLabel1.Size = new System.Drawing.Size(263, 40);
            this.lightCenteredLabel1.TabIndex = 2;
            this.lightCenteredLabel1.Text = "lightCenteredLabel1";
            this.lightCenteredLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lightCenteredLabel1);
            this.Controls.Add(this.lightImageButton1);
            this.Controls.Add(this.lightActionButton1);
            this.Name = "TestApp";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GUIControls.LightTheme.LightActionButton lightActionButton1;
        private GUIControls.LightTheme.LightImageButton lightImageButton1;
        private GUIControls.LightTheme.LightCenteredLabel lightCenteredLabel1;
    }
}

