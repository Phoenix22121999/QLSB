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
    public partial class MonthCalendar : Form
    {
        #region Peoperties
        private List<List<Button>> matrix;
        private List<String> dateOfWeek = new List<String>(){"Monday", "Tuesday", "Wednesday", "Thursday","Friday", "Saturday","Sunday"};
        #endregion
        public MonthCalendar()
        {
            InitializeComponent();
            LoadMatrix();
        }
        // tạo DailyCalendar
        //DailyCalendar DailyForm = new DailyCalendar();
        //tạo ma trận
        void LoadMatrix()
        {
            matrix = new List<List<Button>>();
            Button OLD = new Button() { Height = 0, Width = 0, Location = new Point(-Cons.margin, 0) };

            for (int i = 0; i < Cons.matrixColumn; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.matrixRow; j++)
                {
                    Button btn = new Button() { Height=Cons.hight,Width=Cons.width};
                    btn.Location = new Point(OLD.Location.X + OLD.Width+ Cons.margin, OLD.Location.Y);
                    btn.Click += Btn_Click;
                    panelCalender.Controls.Add(btn);
                    matrix[i].Add(btn);
                    OLD = btn;
                }
                 OLD = new Button() { Height = 0, Width = 0, Location = new Point(-Cons.margin, OLD.Location.Y+Cons.hight) };
            }

            setDefaultDate();


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as Button).Text)) return;
            //DailyCalendar dailyCalendar = new DailyCalendar(new DateTime(DatePickerForMonth.Value.Year, DatePickerForMonth.Value.Month,Convert.ToInt32((sender as Button).Text)));
            DateTime day1 = new DateTime(DatePickerForMonth.Value.Year, DatePickerForMonth.Value.Month, Convert.ToInt32((sender as Button).Text));
            DatePickerForMonth.Value = day1;
            DailyCalendarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DailyCalendarDataGridView.DataSource = getDailyCalendar(day1.ToShortDateString()).Tables[0];
            DailyCalendarDataGridView.ReadOnly = true;
            //dailyCalendar.ShowDialog();

        }

        int NumberDayOfMonth(DateTime date)
        {
            switch (date.Month) {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || (date.Year % 400 == 0)) return 29;
                    else return 28;

                       
                default:
                    return 30;

            }

        }
        void addDate(DateTime date)
        {
            clearMatrixValue();
            int day=1;
            DateTime now = new DateTime(date.Year, date.Month, day);      
            int line = 0;
            int a = NumberDayOfMonth(date);
            for (int i = 1; i <= NumberDayOfMonth(date); i++)
            {
                String b = now.DayOfWeek.ToString();
               int column = dateOfWeek.IndexOf(now.DayOfWeek.ToString());

               Button btn = matrix[line][column];
               btn.Text = i.ToString();
               if(compareDate(now,DateTime.Now))
               {
                   btn.BackColor = Color.Yellow;
               }
                if (compareDate(now, date))
                {
                    btn.BackColor = Color.Red;
                }
                if (column >= 6){
                    line++;
                }
                now = now.AddDays(1);
            }
        }
        bool compareDate(DateTime a,DateTime b)
        {
            return a.Day == b.Day && a.Month == b.Month && a.Year == b.Year;
        }
        void clearMatrixValue()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Button btn = matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }
        void setDefaultDate()
        {
            DatePickerForMonth.Value = DateTime.Now;

        }
        private void DatePickerForMonth_ValueChanged(object sender, EventArgs e)
        {
            addDate((sender as DateTimePicker).Value);
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            DatePickerForMonth.Value = DatePickerForMonth.Value.AddMonths(1);
        }

        private void lastMonthButton_Click(object sender, EventArgs e)
        {
            DatePickerForMonth.Value = DatePickerForMonth.Value.AddMonths(-1);
        }

        private void today_Click(object sender, EventArgs e)
        {
            DatePickerForMonth.Value = DateTime.Now;
        }

        private void DailyCalendarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MonthCalendar_Load(object sender, EventArgs e)
        {
            DateTime day1 = DatePickerForMonth.Value.Date;           
            DailyCalendarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DailyCalendarDataGridView.DataSource = getDailyCalendar(day1.ToShortDateString()).Tables[0];
            DailyCalendarDataGridView.ReadOnly = true;
        }
        DataSet getDailyCalendar(String MaNgay)
        {
            DataSet data = new DataSet();
            // SLQ connection

            String lenh = "select * from Lich where Lich.MaNgay like " + "'" + MaNgay + "'";
            //MessageBox.Show(lenh);
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(lenh, connection);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        private void ChildFormClosing(object sender, FormClosedEventArgs e)
        {
            this.Close();
            InitializeComponent();
        }
        private void BookingButton_Click(object sender, EventArgs e)
        {
            Booking book = new Booking(DatePickerForMonth.Value);
            MessageBox.Show(DatePickerForMonth.Value.ToString());
            //book.FormClosed += new FormClosedEventHandler(ChildFormClosing);
            book.ShowDialog();
            //if (book.ShowDialog()== DialogResult.OK)
            //{
            //    this.Refresh();
            //}
            
        }
    }
}
