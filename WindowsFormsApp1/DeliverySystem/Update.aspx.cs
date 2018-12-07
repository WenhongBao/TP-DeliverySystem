using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeliverySystem
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbxNewDestinationPostcode.Text == "")
            {
                lblError.Text = "Please enter a postcode.";
            }
            else
            {
                Response.Redirect("comfirm.aspx");
            }
            
        }

        protected void btnCancelTheOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("comfirm.aspx");
        }

        protected void btnGotoTrackAParcel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrackAParcel.aspx");
        }
    }
}