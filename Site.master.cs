﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Zaloguj_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void Zaloguj_Click1(object sender, EventArgs e)
    {
        Response.Redirect("~/Account/Login.aspx");
    }
}
