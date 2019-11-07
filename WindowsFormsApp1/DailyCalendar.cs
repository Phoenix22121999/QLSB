using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace QLSB
{
    public partial class DailyCalendar : Form
    {
        private DateTime DateIN;

        public DateTime DateIN1 { get => DateIN; set => DateIN = value; }

        public DailyCalendar(DateTime dateIN)
        {
            InitializeComponent();
            DateIN1 = dateIN;
        }

        private void DailyCalendar_Load(object sender, EventArgs e)
        {
            DateTime day1 =  DateIN1;
            DailyPicker.Value = day1;
            DailyCalendarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DailyCalendarDataGridView.DataSource = getDailyCalendar(day1.ToShortDateString()).Tables[0];
            DailyCalendarDataGridView.ReadOnly = true;
        }
        DataSet getDailyCalendar(String MaNgay)
        {
            DataSet data = new DataSet();
            // SLQ connection
            
            String lenh = "select * from LichNgay where LichNgay.MaNgay like "+ "'" + MaNgay+"'";
            //MessageBox.Show(lenh);
            using (SqlConnection connection =new SqlConnection(Cons.sqlLink))
            {
                connection.Open();
                SqlDataAdapter adapter =new SqlDataAdapter(lenh, connection);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        private void DailyPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime day1 = new DateTime((sender as DateTimePicker).Value.Year, (sender as DateTimePicker).Value.Month, (sender as DateTimePicker).Value.Day);
            DailyCalendarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DailyCalendarDataGridView.DataSource = getDailyCalendar(day1.ToShortDateString()).Tables[0];
            DailyCalendarDataGridView.ReadOnly = true;          
            //MessageBox.Show(day1.ToShortDateString());
            
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            Booking book = new Booking(DailyPicker.Value);
            book.ShowDialog();
        }

        private void DailyCalendarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
