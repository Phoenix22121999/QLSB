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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            design();
            
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimunButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //select Makhau from NhanVien where MaNV like 'NV1'
            //Main f = new Main();
            //f.Show();
            try
            {
                using (SqlConnection connection = new SqlConnection(Cons.sqlLink))
                {
                    DataSet data = new DataSet();
                    connection.Open();
                    String lenh = "select Makhau from NhanVien where MaNV like " + "'" + UserTextBox.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(lenh, connection);
                    adapter.Fill(data);
                    dataGridViewFake.DataSource = data.Tables[0];
                    connection.Close();

                    if (String.Compare((string)dataGridViewFake.Rows[0].Cells[0].Value, PassTextBox.Text, true) == 0)
                    {
                        this.Hide();
                        Main a = new Main(UserTextBox.Text);
                        a.ShowDialog();
                        this.Close();
                    
                    }
                    else
                    {
                        MessageBox.Show("Thong tin sai");
                    }
                }
            }
            catch(Exception a)
            {
                MessageBox.Show("" + a);
            }
            
        }
        public void design()
        {
            LoginLabel.BackColor = Color.Transparent;

            PanelLogin3.BackColor = Color.Transparent;
            UserLabel.ForeColor = Color.FromArgb(255, 250, 255);
            PassLabel.ForeColor = Color.FromArgb(255, 250, 255);
            // textboxes background color and forcolor
            UserTextBox.BackColor = Color.FromArgb(149, 165, 166);
            PassTextBox.BackColor = Color.FromArgb(149, 165, 166);
            UserTextBox.ForeColor = Color.FromArgb(255, 255, 255);
            PassTextBox.ForeColor = Color.FromArgb(255, 255, 255);
            //rgb(255, 250, 101)
            // textboxes background color
            UserTextBox.BackColor = Color.FromArgb(61, 61, 61);
            PassTextBox.BackColor = Color.FromArgb(61, 61, 61);
            //LoginButton
            LoginButton.BackColor = Color.FromArgb(61, 61, 61);
            LoginButton.ForeColor = Color.White;
            LoginLabel.ForeColor = Color.Black;
            LoginButton.FlatAppearance.BorderColor = Color.White;
            ForgotPass.LinkColor = Color.White;
            //OutButton
            OutButton.BackColor = Color.Transparent;
            //OutButton.FlatStyle = FlatStyle.Flat;
            //OutButton.FlatAppearance.BorderColor= Color.Transparent;
            MinimunButton.BackColor = Color.Transparent;
            //MiniButton.FlatStyle = FlatStyle.Flat;          
            //MiniButton.FlatAppearance.BorderColor = Color.Transparent;
        }
    }
}
