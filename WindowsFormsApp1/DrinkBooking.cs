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
    public partial class DrinkBooking : Form
    {
        public DrinkBooking()
        {
            InitializeComponent();
        }

        private void DrinkBooking_Load(object sender, EventArgs e)
        {
            comboBoxYard.Items.AddRange(Cons.san);
            comboBoxHour.Items.AddRange(Cons.gio);
        }

        private void comboBoxYard_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("K");
            if (Array.IndexOf(Cons.san, comboBoxYard.Text) <= -1)
            {
                MessageBox.Show("Không Hợp Lệ");
                comboBoxYard.Text = null;
            }
        }

        private void DrinkBook_Click(object sender, EventArgs e)
        {                  
            if (waterText.Text != null)
            {
                Ex("N1");
            }
            if (redBullText.Text != null)
            {
                Ex("N2");
            }
            if (iceTeaText.Text != null)
            {
                Ex("N3");
            }
            if (stingText.Text != null)
            {
                Ex("N4");
            }

        }
        public void Ex(String MN)
        {
            String maHoaDon = dateTimePicker1.Value.ToShortDateString() + comboBoxHour.Text + comboBoxYard.Text;
            String lenh = "insert into HoaDonNuoc values(@MHD,@MNg,@MG,@MN,@DG)";
            SqlConnection connection = new SqlConnection(Cons.sqlLink);
            SqlCommand command = new SqlCommand(lenh, connection);
            command.Parameters.Add("@MHD", maHoaDon);
            command.Parameters.Add("@MNg", dateTimePicker1.Value.ToShortDateString());
            command.Parameters.Add("@MG", comboBoxHour.Text);
            connection.Open();
            command.Parameters.Add("@MN", MN);
            switch (MN)
            {
                case "N1":
                case "N3":
                    command.Parameters.Add("@DG", 10000 * Int32.Parse(waterText.Text));
                    break;
                case "N2":
                case "N4":
                    command.Parameters.Add("@DG", 12000 * Int32.Parse(waterText.Text));
                    break;
                
               
            }
                
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Con()
        {
            using( SqlConnection con = new SqlConnection(Cons.sqlLink))
            {
                String lenh = "select * from HoaDon Where "; 
            }
        }
    }
  
}
