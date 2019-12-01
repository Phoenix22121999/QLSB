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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
                {
                    DataSet data = new DataSet();
                    String lenh = "insert into NhanVien values (" + textBoxStaffID.Text + "," + textBoxName.Text + "," + textBoxID.Text + "," + dateTimePickerBD.Value + "," + textBoxPass.Text + "," + textBoxPN.Text + ")";
                    connection.Open();
                    SqlCommand command = new SqlCommand(lenh, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                   
                }
            }
            catch (Exception a)
            {

            }
        }
    }
}
