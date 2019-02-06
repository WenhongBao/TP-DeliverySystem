using ClassLibrary;
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
    Int32 CustomerNo = 0;
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

        //create a customer object
        clsCustomer customer = new clsCustomer();
        Boolean Found = false;
        Found = customer.GetCustomerNoByEmail(Sec.UserEMail);
        CustomerNo = customer.CustomerNo;
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
        //No a member is no allow
        if (CustomerNo == 0)
        {
            lblError.Text = "Please Sign-In or Sign-Up first from main page";
        }
        else if (tbxCollectionPostcode.Text=="" || tbxDestinationPostcode.Text=="")
        {
            lblError.Text = "Please fill the list";
        }
        else
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
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
            AddItem.CustomerNo = CustomerNo;
            //Put item into ThisOrder
            AllOrders.ThisOrder = AddItem;
            //Add order and store the PK
            Int32 OrderNoPK = AllOrders.Add();

            //create a class object
            clsInvoice invoice = new clsInvoice();
            //set its properties
            Int32 InvoiceNoPK = invoice.Add(NowDateCreated.ToString(),CalculatePrice(),tbxDestinationPostcode.Text,OrderNoPK);

            Response.Redirect("GotQuickQuote.aspx");
        }
        
    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        double price = CalculatePrice();
        lblPrice.Text = "Price: £" + price;
    }

    private double CalculatePrice()
    {
        //set var
        int multipleValue;
        double price;
        double XSPrice = 2;
        double SPrice = 2.5;
        double MPrice = 3;
        double LPrice = 3.5;
        double XLPrice = 4;
        double XXLPrice = 4.5;
        //Calculate by different country
        if (ddlDestinationCountry.SelectedValue == "UnitedKingdom")
        {
            multipleValue = 3;
            //Calculate by different Sizes
            if (ddlParcelSize.SelectedValue == "XS")
            {
                price = XSPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "S")
            {
                price = SPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "M")
            {
                price = MPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "L")
            {
                price = LPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "XL")
            {
                price = XLPrice * multipleValue;
            }
            else
            {
                price = XXLPrice * multipleValue;
            }
            return price;
        }
        else if (ddlDestinationCountry.SelectedValue == "China")
        {
            multipleValue = 20;
            //Calculate by different Sizes
            if (ddlParcelSize.SelectedValue == "XS")
            {
                price = XSPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "S")
            {
                price = SPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "M")
            {
                price = MPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "L")
            {
                price = LPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "XL")
            {
                price = XLPrice * multipleValue;
            }
            else
            {
                price = XXLPrice * multipleValue;
            }
            return price;
        }
        else if (ddlDestinationCountry.SelectedValue == "UnitedStates")
        {
            multipleValue = 10;
            //Calculate by different Sizes
            if (ddlParcelSize.SelectedValue == "XS")
            {
                price = XSPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "S")
            {
                price = SPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "M")
            {
                price = MPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "L")
            {
                price = LPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "XL")
            {
                price = XLPrice * multipleValue;
            }
            else
            {
                price = XXLPrice * multipleValue;
            }
            return price;
        }
        else
        {
            multipleValue = 15;
            //Calculate by different Sizes
            if (ddlParcelSize.SelectedValue == "XS")
            {
                price = XSPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "S")
            {
                price = SPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "M")
            {
                price = MPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "L")
            {
                price = LPrice * multipleValue;
            }
            else if (ddlParcelSize.SelectedValue == "XL")
            {
                price = XLPrice * multipleValue;
            }
            else
            {
                price = XXLPrice * multipleValue;
            }
            return price;
        }
    }
}