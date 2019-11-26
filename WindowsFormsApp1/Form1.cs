using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSB
{
    public partial class Confirm : Form
    {
        String money;
        public Confirm(String money)
        {
            this.money = money;
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            labelMoney.Text = money;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
