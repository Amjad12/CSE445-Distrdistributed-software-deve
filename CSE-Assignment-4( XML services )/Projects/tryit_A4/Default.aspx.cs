using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Xsl;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
        
        ToHTMLService.Service1Client client = new ToHTMLService.Service1Client();

        string xmlUrl = TextBox1.Text;
        //             "C:/Users/Amjad-AJ/Documents/Visual Studio 2015/Projects/tryit_A4/Books.xml";


        string xsiUrl = TextBox2.Text;
        //            "C:/Users/Amjad-AJ/Documents/Visual Studio 2015/Projects/tryit_A4/Books.xsl";
        try
        {
            Label1.Text = client.TransformXMLToHTML(xmlUrl, xsiUrl);
        }
        catch(Exception ex)
        {
            Label1.Text = ex.ToString();
        }



    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ValidationService1.Service1Client client = new ValidationService1.Service1Client();

        string xmlUrl = TextBox1.Text;
        //             "C:/Users/Amjad-AJ/Documents/Visual Studio 2015/Projects/tryit_A4/Books.xml";
        string xsdUrl = TextBox3.Text;
        //             "C:/Users/Amjad-AJ/Documents/Visual Studio 2015/Projects/tryit_A4/Books.xsd";

        try
        {
            Label2.Text = client.verification(xmlUrl, xsdUrl);
        }
        catch (Exception ex)
        {
            Label2.Text = ex.ToString();
        }

    }
}