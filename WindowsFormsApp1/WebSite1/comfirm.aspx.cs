using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class comfirm : System.Web.UI.Page
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

        lblComfirmText.Text = "Are you sure you want to cancel the order?";
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create an object
        clsOrder AnOrder = new clsOrder();
        string status = "Cancel";
        //Update
        AnOrder.UpdateStatus(Sec.OrderNo,status);
    }

    protected void btnGoToUpdate_Click(object sender, EventArgs e)
    {
        //go to Update
        Response.Redirect("Update.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //go to Update
        Response.Redirect("Update.aspx");
    }
}