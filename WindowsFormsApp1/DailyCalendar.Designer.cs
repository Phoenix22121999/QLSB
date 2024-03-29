﻿namespace QLSB
{
    partial class DailyCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyCalendar));
            this.DailyCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.DailyPicker = new System.Windows.Forms.DateTimePicker();
            this.BookingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DailyCalendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyCalendarDataGridView
            // 
            this.DailyCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyCalendarDataGridView.Location = new System.Drawing.Point(16, 55);
            this.DailyCalendarDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DailyCalendarDataGridView.Name = "DailyCalendarDataGridView";
            this.DailyCalendarDataGridView.RowHeadersWidth = 51;
            this.DailyCalendarDataGridView.Size = new System.Drawing.Size(957, 321);
            this.DailyCalendarDataGridView.TabIndex = 0;
            this.DailyCalendarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DailyCalendarDataGridView_CellContentClick);
            // 
            // DailyPicker
            // 
            this.DailyPicker.Enabled = false;
            this.DailyPicker.Location = new System.Drawing.Point(16, 15);
            this.DailyPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DailyPicker.Name = "DailyPicker";
            this.DailyPicker.Size = new System.Drawing.Size(265, 22);
            this.DailyPicker.TabIndex = 1;
            this.DailyPicker.ValueChanged += new System.EventHandler(this.DailyPicker_ValueChanged);
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(291, 15);
            this.BookingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(167, 25);
            this.BookingButton.TabIndex = 2;
            this.BookingButton.Text = "Đặt Lịch";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // DailyCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 391);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.DailyPicker);
            this.Controls.Add(this.DailyCalendarDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DailyCalendar";
            this.Text = "Lịch Theo Ngày";
            this.Load += new System.EventHandler(this.DailyCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyCalendarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DailyCalendarDataGridView;
        private System.Windows.Forms.DateTimePicker DailyPicker;
        private System.Windows.Forms.Button BookingButton;
    }
}