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
            userTextBox.CharacterCasing = CharacterCasing.Upper;
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
                    String lenh = "select Makhau from NhanVien where MaNV like " + "'" + userTextBox.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(lenh, connection);
                    adapter.Fill(data);
                    dataGridViewFake.DataSource = data.Tables[0];
                    connection.Close();

                    if (String.Compare((string)dataGridViewFake.Rows[0].Cells[0].Value, passTextBox.Text, true) == 0)
                    {
                        this.Hide();
                        Main a = new Main(userTextBox.Text);
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
            loginLabel.BackColor = Color.Transparent;

            panelLogin3.BackColor = Color.Transparent;
            userLabel.ForeColor = Color.FromArgb(255, 250, 255);
            passLabel.ForeColor = Color.FromArgb(255, 250, 255);
            // textboxes background color and forcolor
            userTextBox.BackColor = Color.FromArgb(149, 165, 166);
            passTextBox.BackColor = Color.FromArgb(149, 165, 166);
            userTextBox.ForeColor = Color.FromArgb(255, 255, 255);
            passTextBox.ForeColor = Color.FromArgb(255, 255, 255);
            //rgb(255, 250, 101)
            // textboxes background color
            userTextBox.BackColor = Color.FromArgb(61, 61, 61);
            passTextBox.BackColor = Color.FromArgb(61, 61, 61);
            //LoginButton
            loginButton.BackColor = Color.FromArgb(61, 61, 61);
            loginButton.ForeColor = Color.White;
            loginLabel.ForeColor = Color.Black;
            loginButton.FlatAppearance.BorderColor = Color.White;
            forgotPass.LinkColor = Color.White;
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
