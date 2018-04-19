using System;
using System.Xml;
using System.Xml.Schema;

namespace homework04
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string result = string.Empty;
        public string verification(string xmlURL, string xsdURL)
        {

            XmlSchemaSet schema;
            XmlReaderSettings settings;
            XmlReader reader;
            try
            {
                schema = new XmlSchemaSet();
                settings = new XmlReaderSettings();
                schema.Add(null, "https://raw.githubusercontent.com/jonnhynick/xml-exercise/master/Hotels.xsd");//change into xsdURL
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas = schema;
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
                reader = XmlReader.Create("https://raw.githubusercontent.com/jonnhynick/xml-exercise/master/Hotels.xml", settings);
                while (reader.Read()) { }
                result = "Validation Succesful";
            }
            catch(Exception ex) { }
            return result;
        }

        private void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            result = String.Format("Validation Error: ", e.Message);
        }

        public string xPathSearch(string xmlURL, string expression)
        {
            string result = string.Empty;
            try
            {

            }
            catch(Exception ex) { }
            return result;
        }
    }
}
