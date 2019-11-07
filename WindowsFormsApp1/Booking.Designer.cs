namespace QLSB
{
    partial class Booking
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
            this.components = new System.ComponentModel.Container();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookingName = new System.Windows.Forms.Label();
            this.IDLable = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.TextBox();
            this.BookPhoneNumber = new System.Windows.Forms.TextBox();
            this.NumberPhoneLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HourComboBox = new System.Windows.Forms.ComboBox();
            this.BookingButton = new System.Windows.Forms.Button();
            this.YardLable = new System.Windows.Forms.Label();
            this.YardComboBox = new System.Windows.Forms.ComboBox();
            this.qLSBDataSet = new QLSB.QLSBDataSet();
            this.lichNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lichNgayTableAdapter = new QLSB.QLSBDataSetTableAdapters.LichNgayTableAdapter();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.qLSBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(15, 31);
            this.BookName.Margin = new System.Windows.Forms.Padding(4);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(365, 22);
            this.BookName.TabIndex = 0;
            // 
            // BookingName
            // 
            this.BookingName.AutoSize = true;
            this.BookingName.Location = new System.Drawing.Point(12, 11);
            this.BookingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookingName.Name = "BookingName";
            this.BookingName.Size = new System.Drawing.Size(104, 17);
            this.BookingName.TabIndex = 1;
            this.BookingName.Text = "Người Đặt Sân:";
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Location = new System.Drawing.Point(16, 59);
            this.IDLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(52, 17);
            this.IDLable.TabIndex = 2;
            this.IDLable.Text = "CMND:";
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(15, 79);
            this.BookID.Margin = new System.Windows.Forms.Padding(4);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(365, 22);
            this.BookID.TabIndex = 3;
            // 
            // BookPhoneNumber
            // 
            this.BookPhoneNumber.Location = new System.Drawing.Point(15, 133);
            this.BookPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.BookPhoneNumber.Name = "BookPhoneNumber";
            this.BookPhoneNumber.Size = new System.Drawing.Size(361, 22);
            this.BookPhoneNumber.TabIndex = 5;
            // 
            // NumberPhoneLable
            // 
            this.NumberPhoneLable.AutoSize = true;
            this.NumberPhoneLable.Location = new System.Drawing.Point(12, 113);
            this.NumberPhoneLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberPhoneLable.Name = "NumberPhoneLable";
            this.NumberPhoneLable.Size = new System.Drawing.Size(102, 17);
            this.NumberPhoneLable.TabIndex = 4;
            this.NumberPhoneLable.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giờ:";
            // 
            // HourComboBox
            // 
            this.HourComboBox.FormattingEnabled = true;
            this.HourComboBox.Location = new System.Drawing.Point(15, 181);
            this.HourComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.HourComboBox.Name = "HourComboBox";
            this.HourComboBox.Size = new System.Drawing.Size(165, 24);
            this.HourComboBox.TabIndex = 7;
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(16, 305);
            this.BookingButton.Margin = new System.Windows.Forms.Padding(4);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(100, 28);
            this.BookingButton.TabIndex = 8;
            this.BookingButton.Text = "Thuê";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // YardLable
            // 
            this.YardLable.AutoSize = true;
            this.YardLable.Location = new System.Drawing.Point(16, 210);
            this.YardLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YardLable.Name = "YardLable";
            this.YardLable.Size = new System.Drawing.Size(33, 17);
            this.YardLable.TabIndex = 9;
            this.YardLable.Text = "Sân";
            // 
            // YardComboBox
            // 
            this.YardComboBox.FormattingEnabled = true;
            this.YardComboBox.Location = new System.Drawing.Point(15, 230);
            this.YardComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.YardComboBox.Name = "YardComboBox";
            this.YardComboBox.Size = new System.Drawing.Size(165, 24);
            this.YardComboBox.TabIndex = 10;
            // 
            // qLSBDataSet
            // 
            this.qLSBDataSet.DataSetName = "QLSBDataSet";
            this.qLSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lichNgayBindingSource
            // 
            this.lichNgayBindingSource.DataMember = "LichNgay";
            this.lichNgayBindingSource.DataSource = this.qLSBDataSet;
            // 
            // lichNgayTableAdapter
            // 
            this.lichNgayTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(19, 12);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.RowHeadersWidth = 51;
            this.dataGridViewBooking.RowTemplate.Height = 24;
            this.dataGridViewBooking.Size = new System.Drawing.Size(0, 0);
            this.dataGridViewBooking.TabIndex = 11;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 348);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.YardComboBox);
            this.Controls.Add(this.YardLable);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.HourComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BookPhoneNumber);
            this.Controls.Add(this.NumberPhoneLable);
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.IDLable);
            this.Controls.Add(this.BookingName);
            this.Controls.Add(this.BookName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label BookingName;
        private System.Windows.Forms.Label IDLable;
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.TextBox BookPhoneNumber;
        private System.Windows.Forms.Label NumberPhoneLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HourComboBox;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Label YardLable;
        private System.Windows.Forms.ComboBox YardComboBox;
        private QLSBDataSet qLSBDataSet;
        private System.Windows.Forms.BindingSource lichNgayBindingSource;
        private QLSBDataSetTableAdapters.LichNgayTableAdapter lichNgayTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
    }
}