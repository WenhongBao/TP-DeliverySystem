﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeliverySystem
{
    public partial class comfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblComfirmText.Text = "Are you comfirm to the action?";
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            lblComfirmText.Text = "Action Done!!";
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            lblComfirmText.Text = "Action had been cancel.";
        }

        protected void btnGotoUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update.aspx");
        }
    }
}