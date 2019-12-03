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
                    connection.Open();
                    String lenh = "insert into NhanVien values(@MaNV,@Ten,@ID,@namsinh,@mk,@sdt)";
                    //MessageBox.Show(lenh);
                    
                    SqlCommand command = new SqlCommand(lenh, connection);
                    command.Parameters.Add("@MaNV",textBoxStaffID.Text);
                    command.Parameters.Add("@Ten", textBoxName.Text);
                    command.Parameters.Add("@ID", textBoxID.Text);
                    command.Parameters.Add("@namsinh",dateTimePickerBD.Value);
                    command.Parameters.Add("@mk", textBoxPass.Text);
                    command.Parameters.Add("@sdt", textBoxPN.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    connection.Close();
                   
                }
            }
            catch (Exception a)
            {

            }
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            textBoxName.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
