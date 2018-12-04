using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeliverySystem
{
    public partial class QuickQuote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGotoMainPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnGotoTrackAParcel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrackAParcel.aspx");
        }

        protected void btnGetAQuote_Click(object sender, EventArgs e)
        {
            Response.Redirect("GotQuickQuote.aspx");
        }
    }
}