using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Update : System.Web.UI.Page
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

    }

    protected void btnGotoTrackAParcel_Click(object sender, EventArgs e)
    {
        //go to TrackAParcel
        Response.Redirect("TrackAParcel.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //Check if null
        if (tbxNewDestinationPostcode.Text=="")
        {
            lblError.Text = "Please enter a Postcode";
        }
        else
        {
            //create an object
            clsOrder AnOrder = new clsOrder();
            //Update
            AnOrder.UpdateDestinationPostcode(Sec.OrderNo,tbxNewDestinationPostcode.Text);
            lblError.Text = "The Postcode have been change";
        }
    }

    protected void btnCancelTheOrder_Click(object sender, EventArgs e)
    {
        //go to comfirm
        Response.Redirect("comfirm.aspx");
    }
}