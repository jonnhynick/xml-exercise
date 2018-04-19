using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidationSubmit_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            try
            {
                string URL = "http://localhost:50552/Service1.svc/verification?xmlURL=";
                if (checkValidationTextbox())
                {
                    string appendURL = XMLTextbox.Text + "&xsdURL=" + XSDTextbox.Text;
                    URL += appendURL;
                    ResultValidation.Text = webClient.DownloadString(URL);
                }
            }
            catch(Exception ex) { }
        }

        private bool checkValidationTextbox()
        {
            bool result = false;
            if(!String.IsNullOrEmpty(XMLTextbox.Text) && !String.IsNullOrEmpty(XSDTextbox.Text))
            {
                result = true;
            }
            return result;
        }

        protected void XPathSubmit_Click(object sender, EventArgs e)
        {
            WebClient webclient = new WebClient();
            try
            {
                string URL = "http://localhost:50552/Service1.svc/xPathSearch?xmlURL=";
                if (checkPathTextbox())
                {
                    string appendURL = XMLTextboxSearch.Text + "&expression=" + ExpressionTextbox.Text;
                    URL += appendURL;
                    XPathResult.Text = webclient.DownloadString(URL);
                }
            }
            catch(Exception ex) { }
        }

        private bool checkPathTextbox()
        {
            bool result = false;
            if(!String.IsNullOrEmpty(XMLTextboxSearch.Text) && !String.IsNullOrEmpty(ExpressionTextbox.Text))
            {
                result = true;
            }
            return result;
        }
    }
}