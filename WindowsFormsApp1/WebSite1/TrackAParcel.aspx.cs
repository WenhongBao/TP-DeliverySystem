using ClassLibrary;
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
    Int32 CustomerNo = 0;
    //clsOrderCollection OrderBook = new clsOrderCollection();
    
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
        //create an object
        clsCustomer customer = new clsCustomer();
        Boolean Found = false;
        //get customerNo by email
        Found =customer.GetCustomerNoByEmail(Sec.UserEMail);
        //Get CustomerNo
        CustomerNo = customer.CustomerNo;

        //Check if login
        if (CustomerNo==0)
        {
            lblError.Text = "Please Sign-In first.";
        }
        else {
            DisplayAllOrders(CustomerNo);
        }
    }

    protected void btnGotoMainPage_Click(object sender, EventArgs e)
    {
        //go to Index
        Response.Redirect("Index.aspx");
    }

    protected void btnTrackYourParcel_Click(object sender, EventArgs e)
    {
        if (tbxDestinationPostcode.Text=="")
        {
            lblError.Text = "Please enter a PostCode first.";
        }
        else
        {
            //Filter by Postcode
            DisplayOrders(tbxDestinationPostcode.Text);
        }       
    }

    protected void btnGotoQuickQuote_Click(object sender, EventArgs e)
    {
        //go to QuickQuote
        Response.Redirect("QuickQuote.aspx");
    }

    protected void btnGotoUpdate_Click(object sender, EventArgs e)
    {
        //create an object
        clsOrder order = new clsOrder();

        //Check if string could be convert to int
        if (CheckIfInt(tbxOrderNo.Text)==false)
        {
            lblError.Text = "Please enter an integer";
        }
        //Check if the orderNo is exist
        else if(order.FilterByOrderNo(Convert.ToInt32(tbxOrderNo.Text))==false)
        {
            lblError.Text = "Could not find this OrderNo in your account.";
        }
        //Check if the parcel was Dispatching or Dispathched
        else if (order.Status== "Dispatching" || order.Status == "Dispatched" || order.Status=="Cancel")
        {
            lblError.Text = "The Percel was Dispatching, Dispatched or Cancel.";
        }
        else
        {
            //Store the OrderNo in to Sec
            Sec.OrderNo = Convert.ToInt32(tbxOrderNo.Text);
            //go to Update
            Response.Redirect("Update.aspx");
        }
        
    }

    Int32 DisplayOrders(string DestinationPostcodeFilter)
    {
        clsOrderCollection MyOrderBook = new clsOrderCollection();
        //var to store the count of records
        Int32 RecordCount;
        Int32 OrderNo;
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
        MyOrderBook.FilterByDestinationPostcodeAndCustomerNo(DestinationPostcodeFilter,CustomerNo);
        ////Store the Orderlist
        //OrderBook.OrderList = MyOrderBook.OrderList;
        RecordCount = MyOrderBook.Count;
        while (Index < RecordCount)
        {
            OrderNo = Convert.ToInt32(MyOrderBook.OrderList[Index].OrderNo);
            CollectionPostcode = Convert.ToString(MyOrderBook.OrderList[Index].CollectionPostcode);
            DestinationCountry = Convert.ToString(MyOrderBook.OrderList[Index].DestinationCountry);
            DestinationPostcode = Convert.ToString(MyOrderBook.OrderList[Index].DestinationPostcode);
            DateCreated = Convert.ToString(MyOrderBook.OrderList[Index].DateCreated);
            ParcelSize = Convert.ToString(MyOrderBook.OrderList[Index].ParcelSize);
            Status = Convert.ToString(MyOrderBook.OrderList[Index].Status);
            ListItem NewItem = new ListItem("OrderNo: " + OrderNo + " / " + 
                                            "Collection PC: " + CollectionPostcode + " / " +
                                            "Destination Country: " + DestinationCountry + " / " +
                                            "Destination PC: " + DestinationPostcode + " / " +
                                            "Date Created: " + DateCreated + " / " +
                                            "Parcel Size: " + ParcelSize + " / " +
                                            "Status: " + Status);
            lbxOrderInfor.Items.Add(NewItem);
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    Int32 DisplayAllOrders(Int32 CustomerNo)
    {
        clsOrderCollection MyOrderBook = new clsOrderCollection();
        //var to store the count of records
        Int32 RecordCount;
        Int32 OrderNo;
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
        MyOrderBook.FilterByCustomerNo(CustomerNo);
        ////Store the Orderlist
        //OrderBook.OrderList = MyOrderBook.OrderList;
        RecordCount = MyOrderBook.Count;
        while (Index < RecordCount)
        {
            OrderNo = Convert.ToInt32(MyOrderBook.OrderList[Index].OrderNo);
            CollectionPostcode = Convert.ToString(MyOrderBook.OrderList[Index].CollectionPostcode);
            DestinationCountry = Convert.ToString(MyOrderBook.OrderList[Index].DestinationCountry);
            DestinationPostcode = Convert.ToString(MyOrderBook.OrderList[Index].DestinationPostcode);
            DateCreated = Convert.ToString(MyOrderBook.OrderList[Index].DateCreated);
            ParcelSize = Convert.ToString(MyOrderBook.OrderList[Index].ParcelSize);
            Status = Convert.ToString(MyOrderBook.OrderList[Index].Status);
            ListItem NewItem = new ListItem("OrderNo: " + OrderNo + " / " +
                                            "Collection PC: " + CollectionPostcode + " / " +
                                            "Destination Country: " + DestinationCountry + " / " +
                                            "Destination PC: " + DestinationPostcode + " / " +
                                            "Date Created: " + DateCreated + " / " +
                                            "Parcel Size: " + ParcelSize + " / " +
                                            "Status: " + Status);
            lbxOrderInfor.Items.Add(NewItem);
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    bool CheckIfInt(string Text)
    {
        Int32 number = 0;
        try
        {
            number = Convert.ToInt32(Text);
            return true;
        }
        catch
        {
            return false;
        }
    }
}