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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitDate_Click(object sender, EventArgs e)
        {
            lbxOrderInfor.Items.Clear();
            string orderInfor = "OrderNo: 123, Destination: UK,States: Packaging, DateTime:" +
                                 dtpSearchDate.Value.Date.ToLongDateString() +
                                 ", Destination P.C.:LE2 7FZ, Collection P.C.: LE2 7EE";
            lbxOrderInfor.Items.Add(orderInfor);
        }

        private void btnSubmitOrderNo_Click(object sender, EventArgs e)
        {
            if (tbxSearchOrderNo.Text == "")
            {
                lblError.Text = "Please Input an orderNo for search.";
            }
            else
            {
                lbxOrderInfor.Items.Clear();
                string orderInfor = "OrderNo: " + tbxSearchOrderNo.Text + ", Destination: UK,States: Packaging, DateTime:" +
                                     "Destination P.C.:LE2 7FZ, Collection P.C.: LE2 7EE";
                lbxOrderInfor.Items.Add(orderInfor);
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbxOrderInfor.SelectedIndex == -1)
            {
                lblError.Text = "Please select an order for update.";
            }
            else
            {
                Update update = new Update();
                this.Hide();
                update.ShowDialog();
                
            }
        }
    }
}
