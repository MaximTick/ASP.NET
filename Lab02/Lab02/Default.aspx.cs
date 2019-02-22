using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8092/Lab02/get.tma?name=maks&age=19");
            webRequest.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader reader = new StreamReader(webResponse.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }

        protected  void PostButton_Click(object sender, EventArgs e)
        {
            #region WebClient
            //using (var client = new WebClient())
            //{
            //    var values = new NameValueCollection
            //    {
            //        {"age", "19"},
            //        {"name", "mikser" }
            //    };
            //    byte[] result = client.UploadValues("http://localhost:8092/Lab02/test.tma", values);            

            //     Response.Write(result);
            //}
            #endregion
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8092/Lab02/test.tma");
            request.Method = "POST";
            string postData = "name=maksik&age=19";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream postDataStream = request.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }

        protected void PutButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8092/Lab02/put.tma");
            request.Method = "PUT";

            string puttData = "name=maksik&age=19";
            byte[] byteArray = Encoding.UTF8.GetBytes(puttData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream putDataStream = request.GetRequestStream();
            putDataStream.Write(byteArray, 0, byteArray.Length);
            putDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());

        }

        protected void ErrorButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8092/Lab02/test.err?n=maks&s=men");
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Response.Write(reader.ReadToEnd());
            }
            catch (WebException error)
            {
                Response.Write(error.Status);
                Response.Write("<br/>" + error.Message);
                Response.Write("<br/>" + error.TargetSite);
                Response.Write("<br/>" + error.Source);
            }

        }
    }
}