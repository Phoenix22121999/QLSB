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
    public partial class Booking : Form
    {
        SqlDataAdapter adapter;
        DateTime BookingDate;
        //private String[] gio = new string[] { "6h-7h", "7h-8h", "8h-9h", "9h-10h", "10h-11h", "13h-14h", "14h-15h", "15h-16h", "16h-17h", "17h-18h", "18h-19h", "19h-20h", "20h-21h" };
        //private String[] san = new string[] { "Sân 1", "Sân 2", "Sân 3", "Sân 4", "Sân 5", "Sân 6", "Sân 7", "Sân 8", "Sân 9" };
        public Booking(DateTime BookingDate)
        {
            InitializeComponent();
            this.BookingDate = BookingDate;
            
        }

        private void Booking_Load(object sender, EventArgs e)
        {
           
            HourComboBox.Items.AddRange(Cons.gio);
            YardComboBox.Items.AddRange(Cons.san);
            Design();
        }

        public event Action ReloadMonthCalendar;


        private void BookingButton_Click(object sender, EventArgs e)
        {
           
            String MHD;
            
            try
           {
                
                String lenh = "insert into Khach values(@MaKhach,@TenKhach,@CMND,@SDT)";
                String MaKhach = BookingDate.ToShortDateString() + BookID.Text;
                DateTime day1 = BookingDate.Date;
                dataGridViewBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewBooking.DataSource = getDailyCalendar(day1.ToShortDateString()).Tables[0];
                dataGridViewBooking.ReadOnly = true;
                //MessageBox.Show(dataGridViewBooking.Rows[0].Cells[0].Value.ToString());

               
                if (dataGridViewBooking.Rows[0].Cells[0].Value != null )
                {
                    
                    //MessageBox.Show(dataGridViewBooking.Rows[0].Cells[0].Value.ToString());
                    SqlConnection connection = new SqlConnection(Cons.sqlLink);
                    connection.Open();
                    String lenh4;
                    SqlCommand command4;
                    SqlCommand command = new SqlCommand(lenh, connection);
                    command.Parameters.Add("@MaKhach", MaKhach);
                    command.Parameters.Add("@TenKhach", BookName.Text);
                    command.Parameters.Add("@CMND", BookID.Text);
                    command.Parameters.Add("@SDT", BookPhoneNumber.Text);
                    switch (YardComboBox.Text)
                    {
                        case "Sân 1":
                            lenh4 = "UPDATE Lich SET San1 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            MessageBox.Show(""+lenh4);
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;
                        case "Sân 2":
                            lenh4 = "UPDATE Lich SET San2 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;
                        case "Sân 3":
                            lenh4 = "UPDATE Lich SET San3 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;
                        case "Sân 4":
                            lenh4 = "UPDATE Lich SET San4 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;
                        case "Sân 5":
                            lenh4 = "UPDATE Lich SET San5 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;
                        case "Sân 6":
                            lenh4 = "UPDATE Lich SET San6 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;
                        case "Sân 7":
                            lenh4 = "UPDATE Lich SET San7 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;
                        case "Sân 8":
                            lenh4 = "UPDATE Lich SET San8 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;
                        case "Sân 9":
                            lenh4 = "UPDATE Lich SET San9 = 1 where Lich.MaNgay like " + "'" + BookingDate.Date.ToShortDateString() + "' and Lich.MaGio like '" + HourComboBox.Text + "'";
                            command4 = new SqlCommand(lenh4, connection);
                            command4.ExecuteNonQuery();
                            break;

                    }
                    MakeHD();
                    Close();


                }
                else
                {
                    try {
                        
                        //String lenh2 = "insert into LichNgay(MaNgay,Gio,@San) values(@MaNgay,@gio,@TrueFalse)";
                        using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
                        {
                            String lenh2;
                            if (YardComboBox.Text == "Sân 1")
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San1) values(@MaNgay,@gio,@TrueFalse)";

                            }
                            else if (YardComboBox.Text == "Sân 2")
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San2) values(@MaNgay,@gio,@TrueFalse)";
                            }
                            else if (YardComboBox.Text == "Sân 3")
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San3) values(@MaNgay,@gio,@TrueFalse)";
                            }
                            else if (YardComboBox.Text == "Sân 4")
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San4) values(@MaNgay,@gio,@TrueFalse)";
                            }
                            else if (YardComboBox.Text == "Sân 5")
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San5) values(@MaNgay,@gio,@TrueFalse)";
                            }
                            else if (YardComboBox.Text == "Sân 6")
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San6) values(@MaNgay,@gio,@TrueFalse)";
                            }
                            else if (YardComboBox.Text == "Sân 7")
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San7) values(@MaNgay,@gio,@TrueFalse)";
                            }
                            else if (YardComboBox.Text == "Sân 8")
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San8) values(@MaNgay,@gio,@TrueFalse)";
                            }
                            else
                            {
                                lenh2 = "insert into Lich(MaNgay,MaGio,San9) values(@MaNgay,@gio,@TrueFalse)";
                            }

                            connection.Open();
                            SqlCommand command = new SqlCommand(lenh, connection);
                            command.Parameters.Add("@MaKhach", MaKhach);
                            command.Parameters.Add("@TenKhach", BookName.Text);
                            command.Parameters.Add("@CMND", BookID.Text);
                            command.Parameters.Add("@SDT", BookPhoneNumber.Text);
                            SqlCommand command2 = new SqlCommand(lenh2, connection);
                            command2.Parameters.Add("@san", "San1");
                            command2.Parameters.Add("@TrueFalse", 1);
                            command2.Parameters.Add("@MaNgay", BookingDate.ToShortDateString());
                            command2.Parameters.Add("@gio", HourComboBox.Text);
                            command2.ExecuteNonQuery();
                            command.ExecuteNonQuery();
                            MakeHD();

                        }
                    this.DialogResult = DialogResult.OK;
                    Close();
                    }catch(Exception a)
                    {
                        MessageBox.Show("Đã xảy ra lỗi");
                    }

                }
               
               
            }
           catch(Exception a)
           {
                MessageBox.Show("Đã xảy ra lỗi");
           }
          
       }
        DataSet getDailyCalendar(String MaNgay)
        {
            DataSet data = new DataSet();
            // SLQ connection

            String lenh = "select * from Lich where Lich.MaNgay like " + "'" + MaNgay + "' and Lich.MaGio like '"+HourComboBox.Text+"'";
            //MessageBox.Show(lenh);
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {
                connection.Open();
                adapter = new SqlDataAdapter(lenh, connection);
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public void MakeHD()
        {
            using (SqlConnection connection1 = new SqlConnection(Cons.sqlLink))
            {
                connection1.Open();
                String MaKhach = BookingDate.ToShortDateString() + BookID.Text;
                DateTime day1 = BookingDate.Date;
                String lenh3 = "insert into HoaDon(MaHoaDon,MaKhach,MaNgay,MaGio,San,TongTien) values(@MaHoaDon,@MaKhach,@MaNgay,@MaGio,@San,@TongTien)";
                SqlCommand command3 = new SqlCommand(lenh3, connection1);

                command3.Parameters.Add("@MaHoaDon", MaKhach + day1.ToShortDateString() + HourComboBox.Text);
                command3.Parameters.Add("@MaKhach", MaKhach);
                command3.Parameters.Add("@MaNgay", BookingDate.ToShortDateString());
                command3.Parameters.Add("@MaGio", HourComboBox.Text);
                command3.Parameters.Add("@TongTien", 120000);
                command3.Parameters.Add("@San", YardComboBox.Text);
                command3.ExecuteNonQuery();
                connection1.Close();
            }
        }
        public void Design()
        {
            iDLabel.BackColor = Color.Transparent;
            nameLabel.BackColor = Color.Transparent;
            numberPhoneLable.BackColor = Color.Transparent;
            hourLabel.BackColor = Color.Transparent;
            yardLable.BackColor = Color.Transparent;
            iDLabel.ForeColor = Color.White;
            BookingButton.BackColor = Color.FromArgb(255,75,75,75);
            BookingButton.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0, 0);
            BookingButton.ForeColor = Color.White;
            nameLabel.ForeColor = Color.White;
            numberPhoneLable.ForeColor = Color.White;
            hourLabel.ForeColor = Color.White;
            yardLable.ForeColor = Color.White;
            panelBooking.BackColor = Color.FromArgb(200,75,75,75);
        
        }


    }
}
