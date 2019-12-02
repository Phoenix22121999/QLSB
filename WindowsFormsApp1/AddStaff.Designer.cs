namespace QLSB
{
    partial class AddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaff));
            this.labelStaffID = new System.Windows.Forms.Label();
            this.textBoxStaffID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelBD = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPN = new System.Windows.Forms.TextBox();
            this.labelPN = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelStaffID
            // 
            this.labelStaffID.AutoSize = true;
            this.labelStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStaffID.Location = new System.Drawing.Point(12, 9);
            this.labelStaffID.Name = "labelStaffID";
            this.labelStaffID.Size = new System.Drawing.Size(114, 20);
            this.labelStaffID.TabIndex = 0;
            this.labelStaffID.Text = "Mã Nhân Viên";
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.Location = new System.Drawing.Point(16, 32);
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.Size = new System.Drawing.Size(179, 22);
            this.textBoxStaffID.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(12, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(119, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Tên Nhân Viên";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(16, 128);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(179, 22);
            this.textBoxID.TabIndex = 5;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelID.Location = new System.Drawing.Point(12, 105);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(60, 20);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "CMND";
            // 
            // labelBD
            // 
            this.labelBD.AutoSize = true;
            this.labelBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBD.Location = new System.Drawing.Point(12, 153);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(82, 20);
            this.labelBD.TabIndex = 6;
            this.labelBD.Text = "Năm Sinh";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(16, 224);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(179, 22);
            this.textBoxPass.TabIndex = 9;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPass.Location = new System.Drawing.Point(12, 201);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(80, 20);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Mật Khẩu";
            // 
            // textBoxPN
            // 
            this.textBoxPN.Location = new System.Drawing.Point(16, 272);
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(179, 22);
            this.textBoxPN.TabIndex = 11;
            // 
            // labelPN
            // 
            this.labelPN.AutoSize = true;
            this.labelPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPN.Location = new System.Drawing.Point(12, 249);
            this.labelPN.Name = "labelPN";
            this.labelPN.Size = new System.Drawing.Size(106, 20);
            this.labelPN.TabIndex = 10;
            this.labelPN.Text = "Số điện thoại";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 320);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 54);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Thêm Nhân VIên";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Location = new System.Drawing.Point(16, 176);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(179, 22);
            this.dateTimePickerBD.TabIndex = 13;
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 386);
            this.Controls.Add(this.dateTimePickerBD);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPN);
            this.Controls.Add(this.labelPN);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxStaffID);
            this.Controls.Add(this.labelStaffID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStaffID;
        private System.Windows.Forms.TextBox textBoxStaffID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPN;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
    }
}