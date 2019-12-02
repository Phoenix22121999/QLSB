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
    public partial class Cancel : Form
    {
        int index;
        public Cancel()
        {
            InitializeComponent();
        }

        private void Cancel_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            String lenh = "select HoaDon.* from Khach,HoaDon where Khach.CMND = " + "'" + cancelID.Text + "' and HoaDon.MaKhach = Khach.MaKhach";
            //MessageBox.Show(lenh);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(lenh, connection);
                adapter.Fill(data);
                dataGridViewCancel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewCancel.DataSource = data.Tables[0];
                dataGridViewCancel.ReadOnly = true;
                connection.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //dataGridViewCancel.Rows[index].Cells[];
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {
                try {
                    connection.Open();
                    String lenh = "DELETE FROM HoaDon WHERE HoaDon.MaKhach =  " + "'" + dataGridViewCancel.Rows[index].Cells[1].Value + "'";
                    SqlCommand command = new SqlCommand(lenh, connection);
                    command.ExecuteNonQuery();
                } catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }

                try {                  
                    String lenh2;
                    MessageBox.Show(dataGridViewCancel.Rows[index].Cells[4].Value.ToString());
                    String temp = dataGridViewCancel.Rows[index].Cells[4].Value.ToString();
                    if (String.Compare(temp,"Sân 1",true)==0)
                    {
                        lenh2 = "UPDATE Lich SET San1 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio"+ "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }   
                    else if (String.Compare(temp, "Sân 2", true) == 0)
                    {
                        lenh2 = "UPDATE Lich SET San2 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio" + "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }
                    else if (String.Compare(temp, "Sân 3", true) == 0)
                    {
                        lenh2 = "UPDATE Lich SET San3 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio" + "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }
                    else if (String.Compare(temp, "Sân 4", true) == 0)
                    {
                        lenh2 = "UPDATE Lich SET San4 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio" + "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }
                    else if (String.Compare(temp, "Sân 5", true) == 0)
                    {
                        lenh2 = "UPDATE Lich SET San5 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio" + "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }
                    else if (String.Compare(temp, "Sân 6", true) == 0)
                    {
                        lenh2 = "UPDATE Lich SET San6 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio" + "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }
                    else if (String.Compare(temp, "Sân 7", true) == 0)
                    {
                        lenh2 = "UPDATE Lich SET San7 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio" + "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }
                    else if (String.Compare(temp, "Sân 8", true) == 0)
                    {
                        lenh2 = "UPDATE Lich SET San8 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio" + "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }
                    else
                    {
                        lenh2 = "UPDATE Lich SET San9 = 0 WHERE Lich.MaNgay =  " + "'" + dataGridViewCancel.Rows[index].Cells[2].Value + "'" + " AND " + "Lich.MaGio" + "= '" + dataGridViewCancel.Rows[index].Cells[3].Value + "'";
                    }
                    SqlCommand command2 = new SqlCommand(lenh2, connection);
                    MessageBox.Show(lenh2);
                    command2.ExecuteNonQuery();
                    connection.Close();
                }catch(Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void dataGridViewCancel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(""+e.RowIndex);
            this.index = e.RowIndex;
        }
    }
}
