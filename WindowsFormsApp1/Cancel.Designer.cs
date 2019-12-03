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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancel));
            this.cancelID = new System.Windows.Forms.TextBox();
            this.IDLable = new System.Windows.Forms.Label();
            this.dataGridViewCancel = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelID
            // 
            this.cancelID.Location = new System.Drawing.Point(16, 49);
            this.cancelID.Margin = new System.Windows.Forms.Padding(4);
            this.cancelID.Name = "cancelID";
            this.cancelID.Size = new System.Drawing.Size(177, 22);
            this.cancelID.TabIndex = 7;
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Location = new System.Drawing.Point(13, 29);
            this.IDLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(52, 17);
            this.IDLable.TabIndex = 6;
            this.IDLable.Text = "CMND:";
            // 
            // dataGridViewCancel
            // 
            this.dataGridViewCancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCancel.Location = new System.Drawing.Point(205, 29);
            this.dataGridViewCancel.Name = "dataGridViewCancel";
            this.dataGridViewCancel.RowHeadersWidth = 51;
            this.dataGridViewCancel.RowTemplate.Height = 24;
            this.dataGridViewCancel.Size = new System.Drawing.Size(536, 154);
            this.dataGridViewCancel.TabIndex = 10;
            this.dataGridViewCancel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCancel_CellClick);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 78);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(88, 33);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Tìm";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(106, 78);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 33);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Cancel
            // 
            this.AcceptButton = this.buttonFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 206);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewCancel);
            this.Controls.Add(this.cancelID);
            this.Controls.Add(this.IDLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cancel";
            this.Text = "Cancel";
            this.Load += new System.EventHandler(this.Cancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cancelID;
        private System.Windows.Forms.Label IDLable;
        private System.Windows.Forms.DataGridView dataGridViewCancel;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonCancel;
    }
}