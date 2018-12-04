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
            lbxOrderInfor.Text="(Order Information...)";
        }

        protected void btnGotoQuickQuote_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuickQuote.aspx");
        }

        protected void btnGotoUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update.aspx");
        }
    }
}