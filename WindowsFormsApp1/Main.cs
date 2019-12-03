using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSB
{
    public partial class Main : Form
    {
        String staff;
        public Main(String staff)
        {
            this.staff = staff;
            InitializeComponent();
        }
        protected int sosan = 2;
      
        private void button1_Click(object sender, EventArgs e)
        {
            MonthCalendar f = new MonthCalendar();
            f.Show();
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            String DateNow= now.ToShortDateString();
            yardLoad();
            loadData();
            try
            {
               // MessageBox.Show(dataGridViewYard.Rows[0].Cells[2].Value.ToString());
            }
            catch(Exception ea)
            {
                MessageBox.Show("" + ea);
            }


        }
        public void yardLoad()
        {
            DateTime day1 = DateTime.Now.Date;
            dataGridViewYard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            String Hour = DateTime.Now.Hour.ToString() + "h-" + DateTime.Now.AddHours(1).Hour.ToString() + "h";
            dataGridViewYard.DataSource = getDailyCalendar(day1.ToShortDateString(),Hour).Tables[0];
            dataGridViewYard.ReadOnly = true;
            
            //MessageBox.Show(Hour);
            for(int i= 2; i<= 10; i++)
            {
                if (dataGridViewYard.Rows[0].Cells[i].Value is true && String.Compare(dataGridViewYard.Rows[0].Cells[1].Value.ToString(),Hour,true)==0)
                {
                    switch (Convert.ToInt32(i))
                    {
                        case 2: san1.BackColor = Color.Green;
                            break;
                        case 3:
                            san2.BackColor = Color.Green;
                            break;
                        case 4:
                            san3.BackColor = Color.Green;
                            break;
                        case 5:
                            san4.BackColor = Color.Green;
                            break;
                        case 6:
                            san5.BackColor = Color.Green;
                            break;
                        case 7:
                            san6.BackColor = Color.Green;
                            break;
                        case 8:
                            san7.BackColor = Color.Green;
                            break;
                        case 9:
                            san8.BackColor = Color.Green;
                            break;
                        case 10:
                            san9.BackColor = Color.Green;
                            break;
                    }
                    
                    //MessageBox.Show("ddddd");
                }
            }
            

        }
        DataSet getDailyCalendar(String MaNgay, String MaGio)
        {
            DataSet data = new DataSet();
            // SLQ connection

            String lenh = "select * from Lich where Lich.MaNgay = " + "'" + MaNgay + "' and Lich.MaGio =" + "'" + MaGio + "'";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            DrinkBooking a = new DrinkBooking();
            a.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel a = new Cancel();
            a.Show();
        }
        private void loadData()
        {
            String lenh = "select * from NhanVien where MaNV = " + "'" + staff + "'";
            //MessageBox.Show(lenh);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(lenh, connection);
                adapter.Fill(data);
                dataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewStaff.DataSource = data.Tables[0];
                dataGridViewStaff.ReadOnly = true;
                connection.Close();
            }
            textBoxName.Text = dataGridViewStaff.Rows[0].Cells[1].Value.ToString();
            textBoxName.Enabled = false;
            textBoxID.Text = dataGridViewStaff.Rows[0].Cells[2].Value.ToString();
            textBoxID.Enabled = false;
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut f = new CheckOut();
            f.ShowDialog();
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff f = new AddStaff();
            f.ShowDialog();
        }

        private void buttonAddDrink_Click(object sender, EventArgs e)
        {
            DrinkInput f = new DrinkInput();
            f.ShowDialog();
        }
    }
}
