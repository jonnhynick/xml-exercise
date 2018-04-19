using System;
using System.Collections.Generic;
using System.Xml;

namespace WebApplication
{
    public partial class homework04 : System.Web.UI.Page
    {
        public XmlDocument doc = new XmlDocument();
        public XmlNode node;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = string.Empty;
            string file = ResultTextbox.Text;
            doc.Load(file);
            preorderTraverse(doc.DocumentElement);
        }

        private void preorderTraverse(XmlNode node)
        {
            ResultLabel.Text += String.Format("Type=:{0} Name:{1} Value:{2}{3}", node.NodeType, node.Name, node.Value, Environment.NewLine);
            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;
                foreach(XmlNode child in children)
                {
                    preorderTraverse(child);
                }
            }
        }
    }
}