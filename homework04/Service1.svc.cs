using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace homework04
{
    public class Service1 : IService1
    {
        string result = string.Empty;
        const string XML = "https://raw.githubusercontent.com/jonnhynick/xml-exercise/master/Hotels.xml";
        const string XSD = "https://raw.githubusercontent.com/jonnhynick/xml-exercise/master/Hotels.xsd";
        public string verification(string xmlURL, string xsdURL)
        {

            XmlSchemaSet schema;
            XmlReaderSettings settings;
            XmlReader reader;
            try
            {
                //load schema and xml
                result = string.Empty;
                schema = new XmlSchemaSet();
                settings = new XmlReaderSettings();
                schema.Add(null, xsdURL);
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas = schema;
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
                reader = XmlReader.Create(xmlURL, settings);
                while (reader.Read()) { }   //will throw error if encounters problems while reader the XML 
                if (String.Equals(result, string.Empty))
                {
                    result = "Validation Succesful";
                }
            }
            catch(Exception ex) { }
            return result;
        }

        private void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            //throws error if encountered
            result = String.Format("Validation Error: {0}", e.Message);
        }

        public string xPathSearch(string xmlURL, string expression)
        {            
            string result = string.Empty;
            XPathDocument xDoc;
            XPathNavigator navigator;
            XPathNodeIterator iterator;
            try
            {
                //load document
                xDoc = new XPathDocument(xmlURL);
                navigator = xDoc.CreateNavigator();
                iterator = navigator.Select(expression);//points to the path 
                //iterates on the desired path
                while (iterator.MoveNext())
                {
                    string value = iterator.Current.Value;
                    string name = iterator.Current.Name;

                    result += String.Format("Name: {0}, Value: {1}{2}", name,value, Environment.NewLine);
                }
            }
            catch(Exception ex) { }
            return result;
        }
    }
}
