using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Diagnostics;
using System.Xml.XPath;

namespace Xml_service_1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string TransformXMLToHTML(string inputXml, string xsltString)
        {
            try
            {
                StringWriter output = new StringWriter();
                XPathDocument doc = new XPathDocument(inputXml);
                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(xsltString);
                xt.Transform(doc, null, output);
                return output.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
