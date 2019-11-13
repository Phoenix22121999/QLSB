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
    public partial class DrinkInput : Form
    {
        public DrinkInput()
        {
            InitializeComponent();
        }



        private void DrinkInput_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {
                DataSet data = new DataSet();
                String lenh = "select * from Kho ";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(lenh, connection);
                adapter.Fill(data);
                connection.Close();
                dataGridViewInput.DataSource = data.Tables[0];
            }
        }

        private Boolean check(int storage, int input)
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
        private void buttonInput_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {                    
                connection.Open();
                int valWaterInput = 0;
                int valWaterStore = 0;
                int valRedBullInput = 0;
                int valRedBullStore = 0;
                int valIceTeaInput = 0;
                int valIceteaStore = 0;
                int valStingInput = 0;
                int valStingStore = 0;
                try
                {
                    Int32.TryParse(waterText.Text, out valWaterInput);
                    Int32.TryParse(dataGridViewInput.Rows[0].Cells[1].Value.ToString(), out valWaterStore);
                    Int32.TryParse(redBullText.Text, out valRedBullInput);
                    Int32.TryParse(dataGridViewInput.Rows[1].Cells[1].Value.ToString(), out valRedBullStore);
                    Int32.TryParse(waterText.Text, out valIceTeaInput);
                    Int32.TryParse(dataGridViewInput.Rows[2].Cells[1].Value.ToString(), out valIceteaStore);
                    Int32.TryParse(waterText.Text, out valStingInput);
                    Int32.TryParse(dataGridViewInput.Rows[3].Cells[1].Value.ToString(), out valStingStore);
                }
                catch (Exception a)
                {
                    MessageBox.Show("" + a);
                }
                try
                {
                    if (valWaterInput != 0)
                    {
                        SqlCommand command1 = new SqlCommand(Command("N1", valWaterStore+valWaterInput),connection);
                        //MessageBox.Show(Command("N1", valWaterStore + valWaterInput));
                        command1.ExecuteNonQuery();
                    }
                    if (valWaterInput != 0)
                    {
                        SqlCommand command2 = new SqlCommand(Command("N2", valRedBullInput+valRedBullStore), connection);
                        command2.ExecuteNonQuery();
                    }
                    if (valWaterInput != 0)
                    {
                        SqlCommand command3 = new SqlCommand(Command("N3", valIceTeaInput+valIceteaStore), connection);
                        command3.ExecuteNonQuery();
                    }
                    if (valWaterInput != 0)
                    {
                        SqlCommand command4 = new SqlCommand(Command("N4", valStingInput+valStingStore), connection);
                        command4.ExecuteNonQuery();
                    }

                }
                catch(Exception a)
                {
                    MessageBox.Show("d" + a);
                }
                //SqlCommand command1 = new SqlCommand(Command());
                
                connection.Close();
                this.Close();
            }
        }

        private String Command(String a,int sl)
        {
            string lenh="";
            switch (a)
            {
                case "N1":
                    lenh= "update Kho set SoLuong = " + sl.ToString() + " where MaNuoc = 'N1'";
                    break;
                case "N2":
                    lenh= "update Kho set SoLuong = " + sl.ToString() + " where MaNuoc = 'N2'";
                    break;
                case "N3":
                    lenh= "update Kho set SoLuong = " + sl.ToString() + " where MaNuoc = 'N3'";
                    break;
                case "N4":
                    lenh= "update Kho set SoLuong = " + sl.ToString() + " where MaNuoc = 'N4'";
                    break;
            }
            return lenh;
        }
    }
}
