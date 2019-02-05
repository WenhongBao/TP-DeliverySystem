using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuickQuote : System.Web.UI.Page
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

    protected void btnGotoMainPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnGotoTrackAParcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrackAParcel.aspx");
    }

    protected void btnGetAQuote_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create
        clsOrderCollection AllOrders = new clsOrderCollection();
        //create the item of test data
        clsOrder AddItem = new clsOrder();
        //set its properties
        AddItem.Active = true;
        AddItem.CollectionPostcode = tbxCollectionPostcode.Text;
        AddItem.DestinationCountry = ddlDestinationCountry.SelectedValue;
        AddItem.DestinationPostcode = tbxDestinationPostcode.Text;
        DateTime NowDateCreated = DateTime.Now.Date;
        AddItem.DateCreated = NowDateCreated.ToString();
        AddItem.ParcelSize = ddlParcelSize.SelectedValue;
        AddItem.Status = "Parcel Collecting";
        //AddItem.CustomerNo = Sec.;



        Response.Redirect("GotQuickQuote.aspx");
    }
}