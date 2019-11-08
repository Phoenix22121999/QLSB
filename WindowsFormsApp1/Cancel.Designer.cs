namespace QLSB
{
    partial class Cancel
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
            this.BookPhoneNumber = new System.Windows.Forms.TextBox();
            this.NumberPhoneLable = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.TextBox();
            this.IDLable = new System.Windows.Forms.Label();
            this.dataGridViewCancel = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // BookPhoneNumber
            // 
            this.BookPhoneNumber.Location = new System.Drawing.Point(12, 83);
            this.BookPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.BookPhoneNumber.Name = "BookPhoneNumber";
            this.BookPhoneNumber.Size = new System.Drawing.Size(185, 22);
            this.BookPhoneNumber.TabIndex = 9;
            // 
            // NumberPhoneLable
            // 
            this.NumberPhoneLable.AutoSize = true;
            this.NumberPhoneLable.Location = new System.Drawing.Point(9, 63);
            this.NumberPhoneLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberPhoneLable.Name = "NumberPhoneLable";
            this.NumberPhoneLable.Size = new System.Drawing.Size(89, 17);
            this.NumberPhoneLable.TabIndex = 8;
            this.NumberPhoneLable.Text = "Ngày đã đặt:";
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(12, 29);
            this.BookID.Margin = new System.Windows.Forms.Padding(4);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(185, 22);
            this.BookID.TabIndex = 7;
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Location = new System.Drawing.Point(13, 9);
            this.IDLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(52, 17);
            this.IDLable.TabIndex = 6;
            this.IDLable.Text = "CMND:";
            // 
            // dataGridViewCancel
            // 
            this.dataGridViewCancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCancel.Location = new System.Drawing.Point(70, 155);
            this.dataGridViewCancel.Name = "dataGridViewCancel";
            this.dataGridViewCancel.RowHeadersWidth = 51;
            this.dataGridViewCancel.RowTemplate.Height = 24;
            this.dataGridViewCancel.Size = new System.Drawing.Size(0, 0);
            this.dataGridViewCancel.TabIndex = 10;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(122, 132);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 190);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewCancel);
            this.Controls.Add(this.BookPhoneNumber);
            this.Controls.Add(this.NumberPhoneLable);
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.IDLable);
            this.Name = "Cancel";
            this.Text = "Cancel";
            this.Load += new System.EventHandler(this.Cancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookPhoneNumber;
        private System.Windows.Forms.Label NumberPhoneLable;
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.Label IDLable;
        private System.Windows.Forms.DataGridView dataGridViewCancel;
        private System.Windows.Forms.Button buttonCancel;
    }
}