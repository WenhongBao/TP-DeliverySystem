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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnBacktoLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "" || tbxNewPassword.Text=="" || tbxConfirmNewPass.Text=="")
            {
                lblError.Text = "Please fill the box.";
            }
            else if (tbxNewPassword.Text != tbxConfirmNewPass.Text)
            {
                lblError.Text = "The Confirm new password is different from the new password.";
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
