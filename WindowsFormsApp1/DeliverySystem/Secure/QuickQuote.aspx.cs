using ClassLibrary1;
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
            if (tbxCollectionPostcode.Text == "" || tbxDestinationPostcode.Text=="")
            {
                lblError.Text = "Please enter the Collection Postcode and Delivery Postcode.";
            }
            else
            {

                Response.Redirect("GotQuickQuote.aspx");
            }
            
        }

        ////function for adding new records
        //void Add()
        //{
        //    //create an instance of the tutor book
        //    clsOrderCollection OrderBook = new clsOrderCollection();
        //    //validate the data on the web form
        //    DateTime today = DateTime.Now.Date;
        //    string DateCreated = today.ToString();
        //    string States = "Parcel Collecting";
        //    String Error = OrderBook.ThisOrder.Valid(1,true,tbxCollectionPostcode.Text,ddlDestinationCountry.SelectedValue,tbxDestinationPostcode.Text, DateCreated, ddlParcelSize.SelectedValue, States, txtOfficeLocation.Text);
        //    //if the data is OK then add it to the object
        //    if (Error == "")
        //    {
        //        //get the data entered by the user
        //        TutorBook.ThisTutor.FirstName = txtFirstName.Text;
        //        TutorBook.ThisTutor.LastName = txtLastName.Text;
        //        TutorBook.ThisTutor.Email = txtEmail.Text;
        //        TutorBook.ThisTutor.PhoneNum = txtPhoneNum.Text;
        //        TutorBook.ThisTutor.OfficeLocation = txtOfficeLocation.Text;
        //        //add the record
        //        TutorBook.Add();
        //        //all done so redirect back to the main page
        //        Response.Redirect("TutorList.aspx");
        //    }
        //    else
        //    {
        //        //report an error
        //        lblError.Text = "There were problems with the data entered " + Error;
        //    }
        //}
    }
}