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
        int valWaterInput = 0;
        int valWaterStore = 0;
        int valRedBullInput = 0;
        int valRedBullStore = 0;
        int valIceTeaInput = 0;
        int valIceteaStore = 0;
        int valStingInput = 0;
        int valStingStore = 0;
        public DrinkBooking()
        {
            InitializeComponent();
        }

        private void DrinkBooking_Load(object sender, EventArgs e)
        {
            comboBoxYard.Items.AddRange(Cons.san);
            comboBoxHour.Items.AddRange(Cons.gio);
            LoadData();
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

          if (waterText.Text != null && Check(valWaterStore,valWaterInput))
            {
                Ex("N1");
            }
            if (redBullText.Text != null && Check(valRedBullStore, valRedBullInput))
            {
                Ex("N2");
            }
            if (iceTeaText.Text != null && Check(valIceteaStore, valIceTeaInput))
            {
                Ex("N3");
            }
            if (stingText.Text != null && Check(valStingStore, valStingInput))
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
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {
                DataSet data = new DataSet();
                String lenh = "select * from Kho ";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(lenh, connection);
                adapter.Fill(data);
                connection.Close();
                dataGridViewStore.DataSource = data.Tables[0];
            }
            try
            {
                Int32.TryParse(waterText.Text, out valWaterInput);
                Int32.TryParse(dataGridViewStore.Rows[0].Cells[1].Value.ToString(), out valWaterStore);
                Int32.TryParse(redBullText.Text, out valRedBullInput);
                Int32.TryParse(dataGridViewStore.Rows[1].Cells[1].Value.ToString(), out valRedBullStore);
                Int32.TryParse(waterText.Text, out valIceTeaInput);
                Int32.TryParse(dataGridViewStore.Rows[2].Cells[1].Value.ToString(), out valIceteaStore);
                Int32.TryParse(waterText.Text, out valStingInput);
                Int32.TryParse(dataGridViewStore.Rows[3].Cells[1].Value.ToString(), out valStingStore);
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
            }
        }
        private Boolean Check(int storage, int input)
        {
            if (storage < input)
            {
                return false;
            }
            else if (input < storage)
            {
                return true;
            }
            else return true;
        }


    }
  
}
