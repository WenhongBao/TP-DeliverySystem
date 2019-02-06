using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //create an object based on the security class
    clsSecurity Sec;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the security data from the session
        Sec = (clsSecurity)Session["Sec"];
        //if it is null then this is the first run of the site
        if (Sec == null)
        {
            //initialise the object
            Sec = new clsSecurity();
            //save it to the session
            Session["Sec"] = Sec;
        }

        lblResultOfQuote.Text = "Congratulations, order was created. Our staff will collect your package next working day with invoice.";
    }

    protected void btnGotoIndex_Click(object sender, EventArgs e)
    {
        //go to Index
        Response.Redirect("Index.aspx");
    }

    protected void btnGoToQuickQuote_Click(object sender, EventArgs e)
    {
        //go to QuickQuote
        Response.Redirect("QuickQuote.aspx");
    }

    protected void btnGotoTrackAParcel_Click(object sender, EventArgs e)
    {
        //go to Track a parcel
        Response.Redirect("TrackAParcel.aspx");
    }
}