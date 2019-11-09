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
            String lenh = "select HoaDon.* from Khach,HoaDon where Khach.CMND = " + "'" + cancelID.Text + "'";
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
                String lenh = "DELETE FROM HoaDon WHERE HoaDon.MaKhach =  "+"'"+ dataGridViewCancel.Rows[index].Cells[1].Value + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(lenh, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void dataGridViewCancel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(""+e.RowIndex);
            this.index = e.RowIndex;
        }
    }
}
