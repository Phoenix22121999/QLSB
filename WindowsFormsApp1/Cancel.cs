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
        public Cancel()
        {
            InitializeComponent();
        }

        private void Cancel_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            String lenh = "select * from Khach where Lich.MaNgay like " + "'" + MaNgay + "'";
            //MessageBox.Show(lenh);
            using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(lenh, connection);
                adapter.Fill(data);

                connection.Close();
            }
        }
    }
}
