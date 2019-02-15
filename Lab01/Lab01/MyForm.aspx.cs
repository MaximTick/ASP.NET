using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class MyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text += "<-Load";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Label2.Text += "<-Init";

        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            Label2.Text += "<-Prerender";

        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            Label2.Text += "<-Unload";

        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Label2.Text += "<-PreInit"; //
        }

        protected void Page_Desposed(object sender, EventArgs e)
        {
            Label2.Text += "<-Desposed";

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = Request["__viewstate"];
            Label1.Text = s.Length.ToString();
            Label2.Text += "<-button";

            this.Response.Write("<br>MashineName " + Environment.MachineName);
            this.Response.Write("<br> OS Version " + Environment.OSVersion);
            this.Response.Write("<br> ASP.NET Version" + Environment.Version.ToString());
            this.Response.Write("<br> IP-address " + HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"]);
            this.Response.Write("<br> Объем памяти " + Environment.WorkingSet);
            this.Response.Write("<br> Browser " + Request.Browser.Version);

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label2.ForeColor = Color.Red;
        }
    }
}