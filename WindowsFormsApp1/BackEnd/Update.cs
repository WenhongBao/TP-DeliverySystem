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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            lblCaution.Text = "The Number for the order you are editing is 123.";
        }

        private void btnGotoIndex_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            this.Hide();
            index.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbbSelectStates.SelectedValue == null)
            {
                lblError.Text = "Please select a states for submit.";
            }
            else
            {
                Index index = new Index();
                this.Hide();
                index.ShowDialog();
            }
        }
    }
}
