﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab05
{
    public partial class Form4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String x = "";
            foreach (String s in Request.QueryString)
            {
                x += (" " + s + " " + Request[s]);
            }
            Label1.Text += (x + ": " + DateTime.Now.ToString() + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}