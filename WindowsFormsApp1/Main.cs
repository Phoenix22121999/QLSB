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
        public Main()
        {
            InitializeComponent();
        }
        protected int sosan = 2;
        private void button2_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Sân " + sosan;
            button.Name = "san" + sosan;
            Form f =taoForm(sosan);
            
            sosan++;
         
           button.Click += San2_Click;
            bangsan.Controls.Add(button);
        }

        private void San1_Click(object sender, EventArgs e)
        {
            MonthCalendar f = new MonthCalendar();
            f.Text = "Sân 1";
            f.Show();
        }
        private void San2_Click(object sender, EventArgs e)
        {
            MonthCalendar f = new MonthCalendar();
            f.Text = "Sân 2";
            f.Show();
        }
        private void San3_Click(object sender, EventArgs e)
        {
            MonthCalendar f = new MonthCalendar();
            f.Text = "Sân 1";
            f.Show();
        }

        private Form taoForm(int sosan)
        {
            MonthCalendar f = new MonthCalendar();
            f.Text = "Sân "+sosan;
            return f;
        }

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
            YardLoad();
            
            try
            {
               // MessageBox.Show(dataGridViewYard.Rows[0].Cells[2].Value.ToString());
            }
            catch(Exception ea)
            {
                MessageBox.Show("" + ea);
            }


        }
        public void YardLoad()
        {
            DateTime day1 = DateTime.Now.Date;
            dataGridViewYard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewYard.DataSource = getDailyCalendar(day1.ToShortDateString()).Tables[0];
            dataGridViewYard.ReadOnly = true;
            String Hour = DateTime.Now.Hour.ToString()+"h-"+ DateTime.Now.AddHours(1).Hour.ToString()+"h";
            //MessageBox.Show(Hour);
            for(int i= 2; i<= 10; i++)
            {
                if (dataGridViewYard.Rows[0].Cells[i].Value is true && String.Compare(dataGridViewYard.Rows[0].Cells[1].Value.ToString(),Hour,true)==0)
                {
                    switch (Convert.ToInt32(i))
                    {
                        case 2: San1.BackColor = Color.Green;
                            break;
                        case 3:
                            San2.BackColor = Color.Green;
                            break;
                        case 4:
                            San3.BackColor = Color.Green;
                            break;
                        case 5:
                            San4.BackColor = Color.Green;
                            break;
                        case 6:
                            San5.BackColor = Color.Green;
                            break;
                        case 7:
                            San6.BackColor = Color.Green;
                            break;
                        case 8:
                            San7.BackColor = Color.Green;
                            break;
                        case 9:
                            San8.BackColor = Color.Green;
                            break;
                        case 10:
                            San9.BackColor = Color.Green;
                            break;
                    }
                    
                    //MessageBox.Show("ddddd");
                }
            }
            

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
    }
}
