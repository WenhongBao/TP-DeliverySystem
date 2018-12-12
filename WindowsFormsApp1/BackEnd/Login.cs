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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxAccount.Text == "" || tbxPassword.Text == "")
            {
                //show error message if accont or password are blank
                lblError.Text = "Please input your account and password.";
            }
            else
            {
                //new an index object
                Index index = new Index();
                //hide this form
                this.Hide();
                //show index form
                index.ShowDialog();
            }
        }

        private void linklblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //new a forget password object
            ForgetPassword forgetPassword = new ForgetPassword();
            //hide this form
            this.Hide();
            //show forget password form
            forgetPassword.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //new a register object
            Register register = new Register();
            // hide this form
            this.Hide();
            //show register form
            register.ShowDialog();
        }
    }
}
