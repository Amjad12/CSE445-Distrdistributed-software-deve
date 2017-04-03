using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace Xml_service_2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static string output = " ";
        public string verification(string xmlUrl, string xsdUrl)
        {
            try
            {
            
            XmlSchemaSet sc = new XmlSchemaSet();
            sc.Add(null, xsdUrl);
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = sc;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

            XmlReader reader = XmlReader.Create(xmlUrl, settings);

            while (reader.Read()) ;


            output = "Validation is complete";

            return output;
        }
            catch(Exception ex)
            {
                return ex.Message.ToString();
            }
          
        }
        private static void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            output = "Validation Error: " + e.Message;
        }
        
    }
}
