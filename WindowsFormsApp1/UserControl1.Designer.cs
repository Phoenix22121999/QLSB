namespace Hour
{
    partial class Hour
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RentCheckBox = new System.Windows.Forms.CheckBox();
            this.Hire = new System.Windows.Forms.Button();
            this.RenderLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RenderLabel);
            this.panel1.Controls.Add(this.RentCheckBox);
            this.panel1.Controls.Add(this.Hire);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 37);
            this.panel1.TabIndex = 0;
            // 
            // RentCheckBox
            // 
            this.RentCheckBox.AutoSize = true;
            this.RentCheckBox.Enabled = false;
            this.RentCheckBox.Location = new System.Drawing.Point(3, 11);
            this.RentCheckBox.Name = "RentCheckBox";
            this.RentCheckBox.Size = new System.Drawing.Size(97, 17);
            this.RentCheckBox.TabIndex = 2;
            this.RentCheckBox.Text = "Đã Được Thuê";
            this.RentCheckBox.UseVisualStyleBackColor = true;
            // 
            // Hire
            // 
            this.Hire.Location = new System.Drawing.Point(246, 4);
            this.Hire.Name = "Hire";
            this.Hire.Size = new System.Drawing.Size(75, 30);
            this.Hire.TabIndex = 0;
            this.Hire.Text = "Thuê";
            this.Hire.UseVisualStyleBackColor = true;
            // 
            // RenderLabel
            // 
            this.RenderLabel.AutoSize = true;
            this.RenderLabel.Location = new System.Drawing.Point(106, 12);
            this.RenderLabel.Name = "RenderLabel";
            this.RenderLabel.Size = new System.Drawing.Size(35, 13);
            this.RenderLabel.TabIndex = 3;
            this.RenderLabel.Text = "label1";
            // 
            // Hour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Hour";
            this.Size = new System.Drawing.Size(627, 47);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Hire;
        private System.Windows.Forms.CheckBox RentCheckBox;
        private System.Windows.Forms.Label RenderLabel;
    }
}
