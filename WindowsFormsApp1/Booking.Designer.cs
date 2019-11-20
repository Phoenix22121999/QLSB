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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.BookName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.iDLabel = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.TextBox();
            this.BookPhoneNumber = new System.Windows.Forms.TextBox();
            this.numberPhoneLable = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.HourComboBox = new System.Windows.Forms.ComboBox();
            this.BookingButton = new System.Windows.Forms.Button();
            this.yardLable = new System.Windows.Forms.Label();
            this.YardComboBox = new System.Windows.Forms.ComboBox();
            this.qLSBDataSet = new QLSB.QLSBDataSet();
            this.lichNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lichNgayTableAdapter = new QLSB.QLSBDataSetTableAdapters.LichNgayTableAdapter();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.panelBooking = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.qLSBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.panelBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(4, 30);
            this.BookName.Margin = new System.Windows.Forms.Padding(4);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(365, 22);
            this.BookName.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nameLabel.Location = new System.Drawing.Point(4, 6);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(136, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Người Đặt Sân:";
            // 
            // iDLabel
            // 
            this.iDLabel.AutoSize = true;
            this.iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.iDLabel.Location = new System.Drawing.Point(4, 56);
            this.iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(71, 24);
            this.iDLabel.TabIndex = 2;
            this.iDLabel.Text = "CMND:";
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(3, 83);
            this.BookID.Margin = new System.Windows.Forms.Padding(4);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(365, 22);
            this.BookID.TabIndex = 3;
            // 
            // BookPhoneNumber
            // 
            this.BookPhoneNumber.Location = new System.Drawing.Point(3, 137);
            this.BookPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.BookPhoneNumber.Name = "BookPhoneNumber";
            this.BookPhoneNumber.Size = new System.Drawing.Size(366, 22);
            this.BookPhoneNumber.TabIndex = 5;
            // 
            // numberPhoneLable
            // 
            this.numberPhoneLable.AutoSize = true;
            this.numberPhoneLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numberPhoneLable.Location = new System.Drawing.Point(4, 109);
            this.numberPhoneLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberPhoneLable.Name = "numberPhoneLable";
            this.numberPhoneLable.Size = new System.Drawing.Size(135, 24);
            this.numberPhoneLable.TabIndex = 4;
            this.numberPhoneLable.Text = "Số Điện Thoại:";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.hourLabel.Location = new System.Drawing.Point(4, 163);
            this.hourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(44, 24);
            this.hourLabel.TabIndex = 6;
            this.hourLabel.Text = "Giờ:";
            // 
            // HourComboBox
            // 
            this.HourComboBox.FormattingEnabled = true;
            this.HourComboBox.Location = new System.Drawing.Point(3, 186);
            this.HourComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.HourComboBox.Name = "HourComboBox";
            this.HourComboBox.Size = new System.Drawing.Size(165, 24);
            this.HourComboBox.TabIndex = 7;
            // 
            // BookingButton
            // 
            this.BookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BookingButton.Location = new System.Drawing.Point(4, 274);
            this.BookingButton.Margin = new System.Windows.Forms.Padding(4);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(166, 50);
            this.BookingButton.TabIndex = 8;
            this.BookingButton.Text = "Thuê";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // yardLable
            // 
            this.yardLable.AutoSize = true;
            this.yardLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yardLable.Location = new System.Drawing.Point(4, 214);
            this.yardLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yardLable.Name = "yardLable";
            this.yardLable.Size = new System.Drawing.Size(43, 24);
            this.yardLable.TabIndex = 9;
            this.yardLable.Text = "Sân";
            // 
            // YardComboBox
            // 
            this.YardComboBox.FormattingEnabled = true;
            this.YardComboBox.Location = new System.Drawing.Point(4, 242);
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
            // panelBooking
            // 
            this.panelBooking.AutoScroll = true;
            this.panelBooking.AutoSize = true;
            this.panelBooking.Controls.Add(this.nameLabel);
            this.panelBooking.Controls.Add(this.BookingButton);
            this.panelBooking.Controls.Add(this.YardComboBox);
            this.panelBooking.Controls.Add(this.BookName);
            this.panelBooking.Controls.Add(this.yardLable);
            this.panelBooking.Controls.Add(this.iDLabel);
            this.panelBooking.Controls.Add(this.BookID);
            this.panelBooking.Controls.Add(this.HourComboBox);
            this.panelBooking.Controls.Add(this.numberPhoneLable);
            this.panelBooking.Controls.Add(this.hourLabel);
            this.panelBooking.Controls.Add(this.BookPhoneNumber);
            this.panelBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooking.Location = new System.Drawing.Point(0, 0);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(372, 337);
            this.panelBooking.TabIndex = 12;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(372, 337);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.panelBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.panelBooking.ResumeLayout(false);
            this.panelBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.TextBox BookPhoneNumber;
        private System.Windows.Forms.Label numberPhoneLable;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.ComboBox HourComboBox;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Label yardLable;
        private System.Windows.Forms.ComboBox YardComboBox;
        private QLSBDataSet qLSBDataSet;
        private System.Windows.Forms.BindingSource lichNgayBindingSource;
        private QLSBDataSetTableAdapters.LichNgayTableAdapter lichNgayTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.Panel panelBooking;
    }
}