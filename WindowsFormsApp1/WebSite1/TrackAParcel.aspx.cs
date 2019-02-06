using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TrackAParcel : System.Web.UI.Page
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
        //go to Index
        Response.Redirect("Index.aspx");
    }

    protected void btnTrackYourParcel_Click(object sender, EventArgs e)
    {

    }

    protected void btnGotoQuickQuote_Click(object sender, EventArgs e)
    {
        //go to QuickQuote
        Response.Redirect("QuickQuote.aspx");
    }

    protected void btnGotoUpdate_Click(object sender, EventArgs e)
    {
        //go to Update
        Response.Redirect("Update.aspx");
    }

    Int32 DisplayOrders(string DestinationPostcodeFilter)
    {
        clsOrderCollection MyOrderBook = new clsOrderCollection();
        //var to store the count of records
        Int32 RecordCount;
        string CollectionPostcode;
        string DestinationCountry;
        string DestinationPostcode;
        string DateCreated;
        string ParcelSize;
        string Status;

        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lbxOrderInfor.Items.Clear();
        //call the filter by post code method
        MyOrderBook.FilterByDestinationPostcode(DestinationPostcodeFilter);
        RecordCount = MyOrderBook.Count;
        while (Index < RecordCount)
        {
            CollectionPostcode = Convert.ToString(MyOrderBook.OrderList[Index].CollectionPostcode);
            DestinationCountry = Convert.ToString(MyOrderBook.OrderList[Index].DestinationCountry);
            DestinationPostcode = Convert.ToString(MyOrderBook.OrderList[Index].DestinationPostcode);
            DateCreated = Convert.ToString(MyOrderBook.OrderList[Index].DateCreated);
            ParcelSize = Convert.ToString(MyOrderBook.OrderList[Index].ParcelSize);
            Status = Convert.ToString(MyOrderBook.OrderList[Index].Status);
            ListItem NewItem = new ListItem(CollectionPostcode + " " + DestinationCountry + " " + DestinationPostcode + " " + DateCreated + " " + ParcelSize + " " + Status);
            lbxOrderInfor.Items.Add(NewItem);
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }
}