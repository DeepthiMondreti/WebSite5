﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LogIn login = new LogIn();
        int personKey = login.Validate(txtUserName.Text, txtPassword.Text);
        if (personKey != 0)
        {
            
            lblError.Text = "Welcome";
            Session["person"] = personKey;
            Response.Redirect("Donate.aspx");
           
        }
        else
        {
            lblError.Text = "Invalid Login";
        }
    }
}