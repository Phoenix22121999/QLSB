namespace QLSB
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridViewCheckOut = new System.Windows.Forms.DataGridView();
            this.cancelID = new System.Windows.Forms.TextBox();
            this.IDLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(102, 61);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(87, 57);
            this.buttonCheckOut.TabIndex = 17;
            this.buttonCheckOut.Text = "Thanh Toán";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(8, 61);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(88, 57);
            this.buttonFind.TabIndex = 16;
            this.buttonFind.Text = "Tìm";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataGridViewCheckOut
            // 
            this.dataGridViewCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckOut.Location = new System.Drawing.Point(201, 12);
            this.dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            this.dataGridViewCheckOut.RowHeadersWidth = 51;
            this.dataGridViewCheckOut.RowTemplate.Height = 24;
            this.dataGridViewCheckOut.Size = new System.Drawing.Size(536, 106);
            this.dataGridViewCheckOut.TabIndex = 15;
            this.dataGridViewCheckOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheckOut_CellClick);
            // 
            // cancelID
            // 
            this.cancelID.Location = new System.Drawing.Point(12, 32);
            this.cancelID.Margin = new System.Windows.Forms.Padding(4);
            this.cancelID.Name = "cancelID";
            this.cancelID.Size = new System.Drawing.Size(177, 22);
            this.cancelID.TabIndex = 14;
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Location = new System.Drawing.Point(9, 12);
            this.IDLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(52, 17);
            this.IDLable.TabIndex = 13;
            this.IDLable.Text = "CMND:";
            // 
            // CheckOut
            // 
            this.AcceptButton = this.buttonFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 137);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridViewCheckOut);
            this.Controls.Add(this.cancelID);
            this.Controls.Add(this.IDLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOut";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridViewCheckOut;
        private System.Windows.Forms.TextBox cancelID;
        private System.Windows.Forms.Label IDLable;
    }
}