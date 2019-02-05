﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
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
        //set the state of the menu buttons
        Authenticated(Sec.Authenticated);

        //create a customer object
        clsCustomer customer = new clsCustomer();
        string FirstName = customer.GetFirstNameByEmail(Sec.UserEMail);
        lblHi.Text = "Hi~  " + FirstName;
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //go to sign in
        Response.Redirect("SignIn.aspx");

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //go to sign up
        Response.Redirect("SignUp.aspx");

    }

    protected void btnQuickQuote_Click(object sender, EventArgs e)
    {
        //go to QuickQuote
        Response.Redirect("QuickQuote.aspx");

    }

    protected void btnTrackAParcel_Click(object sender, EventArgs e)
    {
        //go to Track a parcel
        Response.Redirect("TrackAParcel.aspx");

    }

    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        //go to sign out
        Response.Redirect("SignOut.aspx");

    }

    protected void btnReSet_Click(object sender, EventArgs e)
    {
        //go to re-set
        Response.Redirect("ReSet.aspx");

    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        //go to change password
        Response.Redirect("ChangePassword.aspx");

    }

    void Authenticated(Boolean Auth)
    {
        //sets the visibility of the buttons on the main menu based on authentication state
        //if not logged in then dsiplay the following
        btnLogin.Visible = !Auth;
        btnRegister.Visible = !Auth;
        btnReSet.Visible = !Auth;
        //if logged in display the following
        btnChangePassword.Visible = Auth;
        btnSignOut.Visible = Auth;
    }

}