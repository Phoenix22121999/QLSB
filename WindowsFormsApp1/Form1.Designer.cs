namespace QLSB
{
    partial class Confirm
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelSumMoney = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(12, 113);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(126, 35);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Xác Nhận ";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelSumMoney
            // 
            this.labelSumMoney.AutoSize = true;
            this.labelSumMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelSumMoney.Location = new System.Drawing.Point(12, 9);
            this.labelSumMoney.Name = "labelSumMoney";
            this.labelSumMoney.Size = new System.Drawing.Size(114, 24);
            this.labelSumMoney.TabIndex = 1;
            this.labelSumMoney.Text = "Tổng tiền là:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(41, 59);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(46, 17);
            this.labelMoney.TabIndex = 2;
            this.labelMoney.Text = "label1";
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 160);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelSumMoney);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelSumMoney;
        private System.Windows.Forms.Label labelMoney;
    }
}