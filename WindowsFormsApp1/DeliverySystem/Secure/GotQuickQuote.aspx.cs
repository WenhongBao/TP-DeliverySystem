using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeliverySystem
{
    public partial class GotQuickQuote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResultOfQuote.Text = "The order has been submitted and the bill will be delivered to you when we collecting the parcel.";
        }

        protected void btnGotoIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnGoToQuickQuote_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuickQuote.aspx");
        }

        protected void btnGotoTrackAParcel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrackAParcel.aspx");
        }
    }
}