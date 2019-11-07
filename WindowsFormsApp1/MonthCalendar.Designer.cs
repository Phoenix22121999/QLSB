namespace QLSB
{
    partial class MonthCalendar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.today = new System.Windows.Forms.Button();
            this.DatePickerForMonth = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCalender = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nextMonthButton = new System.Windows.Forms.Button();
            this.lastMonthButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DailyCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.BookingButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyCalendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 346);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.today);
            this.panel3.Controls.Add(this.DatePickerForMonth);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 28);
            this.panel3.TabIndex = 2;
            // 
            // today
            // 
            this.today.Location = new System.Drawing.Point(353, 2);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(75, 23);
            this.today.TabIndex = 1;
            this.today.Text = "Hôm Nay";
            this.today.UseVisualStyleBackColor = true;
            this.today.Click += new System.EventHandler(this.today_Click);
            // 
            // DatePickerForMonth
            // 
            this.DatePickerForMonth.AllowDrop = true;
            this.DatePickerForMonth.Location = new System.Drawing.Point(169, 5);
            this.DatePickerForMonth.Name = "DatePickerForMonth";
            this.DatePickerForMonth.Size = new System.Drawing.Size(178, 20);
            this.DatePickerForMonth.TabIndex = 0;
            this.DatePickerForMonth.ValueChanged += new System.EventHandler(this.DatePickerForMonth_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCalender);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 310);
            this.panel2.TabIndex = 1;
            // 
            // panelCalender
            // 
            this.panelCalender.AutoScroll = true;
            this.panelCalender.Location = new System.Drawing.Point(94, 54);
            this.panelCalender.Name = "panelCalender";
            this.panelCalender.Size = new System.Drawing.Size(460, 283);
            this.panelCalender.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nextMonthButton);
            this.panel4.Controls.Add(this.lastMonthButton);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(634, 45);
            this.panel4.TabIndex = 0;
            // 
            // nextMonthButton
            // 
            this.nextMonthButton.Location = new System.Drawing.Point(545, 3);
            this.nextMonthButton.Name = "nextMonthButton";
            this.nextMonthButton.Size = new System.Drawing.Size(59, 39);
            this.nextMonthButton.TabIndex = 9;
            this.nextMonthButton.Text = ">>>>";
            this.nextMonthButton.UseVisualStyleBackColor = true;
            this.nextMonthButton.Click += new System.EventHandler(this.nextMonthButton_Click);
            // 
            // lastMonthButton
            // 
            this.lastMonthButton.Location = new System.Drawing.Point(26, 3);
            this.lastMonthButton.Name = "lastMonthButton";
            this.lastMonthButton.Size = new System.Drawing.Size(59, 39);
            this.lastMonthButton.TabIndex = 8;
            this.lastMonthButton.Text = "<<<<";
            this.lastMonthButton.UseVisualStyleBackColor = true;
            this.lastMonthButton.Click += new System.EventHandler(this.lastMonthButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(480, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 39);
            this.button7.TabIndex = 7;
            this.button7.Text = "Chủ Nhật";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(415, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 39);
            this.button6.TabIndex = 6;
            this.button6.Text = "Thứ 7";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(350, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Thứ 6";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Thứ 5";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thứ 4";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thứ 3";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thứ 2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DailyCalendarDataGridView
            // 
            this.DailyCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyCalendarDataGridView.Location = new System.Drawing.Point(638, 12);
            this.DailyCalendarDataGridView.Name = "DailyCalendarDataGridView";
            this.DailyCalendarDataGridView.Size = new System.Drawing.Size(569, 300);
            this.DailyCalendarDataGridView.TabIndex = 1;
            this.DailyCalendarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DailyCalendarDataGridView_CellContentClick);
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(638, 318);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(569, 28);
            this.BookingButton.TabIndex = 3;
            this.BookingButton.Text = "Đặt Lịch";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 386);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.DailyCalendarDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "MonthCalendar";
            this.Text = "Lịch Theo Tháng";
            this.Load += new System.EventHandler(this.MonthCalendar_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DailyCalendarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button today;
        private System.Windows.Forms.DateTimePicker DatePickerForMonth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCalender;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextMonthButton;
        private System.Windows.Forms.Button lastMonthButton;
        private System.Windows.Forms.DataGridView DailyCalendarDataGridView;
        private System.Windows.Forms.Button BookingButton;
    }
}