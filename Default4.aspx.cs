﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //In this code we get the values from the URL using
        //the Request object and then display them
        //in the label
        string firstName = Request.QueryString["FirstName"];
        string lastName = Request.QueryString["LastName"];
        Label1.Text = "Thank you, " + firstName + " " + lastName + " for your donation";
    }
}