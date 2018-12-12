using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnGotoLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbxAccount.Text == "")
            {
                lblError.Text = "Please input your account.";
            }
            else
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }
        }
    }
}
