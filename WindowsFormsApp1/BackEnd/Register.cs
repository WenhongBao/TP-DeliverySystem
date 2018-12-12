﻿using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           if(cbxTitle.SelectedIndex==-1 || tbxFirstName.Text==""|| tbxFirstName.Text == "" || tbxLastName.Text == "" || tbxEmail.Text== "" || tbxPhoneNumber.Text == "")
            {
                lblError.Text = "Please fill the form.";
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
