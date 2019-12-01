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
    public partial class CheckOut : Form
    {
        int index; 
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
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
                dataGridViewCheckOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewCheckOut.DataSource = data.Tables[0];
                dataGridViewCheckOut.ReadOnly = true;
                connection.Close();
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            Confirm a = new Confirm(dataGridViewCheckOut.Rows[index].Cells[7].Value.ToString());
            a.Show();
        }

        private void dataGridViewCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.index = e.RowIndex;
        }
    }
}
