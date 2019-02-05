using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //create a new instance of the security class
        clsSecurity Sec = new clsSecurity();
        clsCustomer customer = new clsCustomer();
        //try to sign up using the supplied credentials
        string Outcome = Sec.SignUp(txtEMail.Text, txtPassword1.Text, txtPassword2.Text, false);
        string Outcome1 = "";
        //If the Valid result is OK
        if (Outcome == "An email has been sent to your account allowing you to activate the account")
        {
            //Valid the information for customer
            Outcome1 = customer.Valid(1, txtEMail.Text, txtFirstName.Text, txtLastName.Text, txtPostcode.Text, txtTelephone.Text, ddlTitle.SelectedValue);
            //If the Valid result is OK
            if (Outcome1 == "")
            {
                ////Get the AccountNo
                //int AccountNo = Sec.GetAccountNoByEmail(txtEMail.Text);
                //insert customer details and stroe the value for primary key
                int PrimaryKey = customer.Add(txtEMail.Text, txtFirstName.Text, txtLastName.Text, txtPostcode.Text, txtTelephone.Text, ddlTitle.SelectedValue);
                //put the value for primary key into tblAccount
                Sec.UpdateCustomerNo(txtEMail.Text, PrimaryKey);
            }
        }

        //report the outcome of the operation
        lblError.Text = Outcome + Outcome1;
        //store the object in the session objec for other pages to access
        Session["Sec"] = Sec;
    }

    protected void btnDone_Click(object sender, EventArgs e)
    {
        //if done redirect to main page
        Response.Redirect("Index.aspx");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        //view the email
        Response.Redirect("EMailViewer.aspx");
    }

    protected void btnReSend_Click(object sender, EventArgs e)
    {
        //display re-set password form
        Response.Redirect("ReSet.aspx");
    }
}