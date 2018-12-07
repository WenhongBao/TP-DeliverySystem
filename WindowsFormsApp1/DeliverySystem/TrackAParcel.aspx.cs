using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeliverySystem
{
    public partial class TrackAParcel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGotoMainPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnTrackYourParcel_Click(object sender, EventArgs e)
        {
            if (tbxOrderNumber.Text == "")
            {
                lblError.Text = "Please enter an order number.";
            }
            else
            {
                string displayOrderNo = "OrderNo: " + tbxOrderNumber.Text;
                string displayCollectionPostcode = "Collection Postcode: " + "LE2 7EE";
                string displayDestination = "Destination: " + "UK";
                string displayDestinationPostcode = "Destination Postcode: " + "LE2 7FZ";
                string DisplayStates = "States: " + "Packaging";

                lbxOrderInfor.Items.Add(displayOrderNo);
                lbxOrderInfor.Items.Add(displayCollectionPostcode);
                lbxOrderInfor.Items.Add(displayDestination);
                lbxOrderInfor.Items.Add(displayDestinationPostcode);
                lbxOrderInfor.Items.Add(DisplayStates);
            }
            
        }

        protected void btnGotoQuickQuote_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuickQuote.aspx");
        }

        protected void btnGotoUpdate_Click(object sender, EventArgs e)
        {
            if (tbxOrderNumber.Text == "")
            {
                lblError.Text = "Please enter an order number.";
            }
            else
            {
                Response.Redirect("Update.aspx");
            }
        }
    }
}