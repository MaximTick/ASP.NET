using System;
using System.Web.UI;

namespace Lab04
{
    public partial class MyWebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button2.CssClass = "button";
            Label2.CssClass = "text";
        }
    }
}