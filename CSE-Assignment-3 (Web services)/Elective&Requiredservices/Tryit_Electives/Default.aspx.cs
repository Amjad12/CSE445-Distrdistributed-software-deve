using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Net;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        WebClient proxy = new WebClient();
        string t = TextBox1.Text.ToString();
        string z = TextBox2.Text;
        string serviceLink = string.Format("http://webstrar6.fulton.asu.edu/page3/Service1.svc/getLocation/"+t+"/"+z);
        //string serviceLink = string.Format("http://localhost:8341/Service1.svc/getLocation/"+t+"/"+z);
        Response.Redirect(serviceLink);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bEnergy.Service1Client bE = new bEnergy.Service1Client();
        Int32 A = Convert.ToInt32(TextBox3.Text);
        Int32 Z = Convert.ToInt32(TextBox4.Text);
        Label2.Text = bE.bindingEnergy(A, Z).ToString();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        WebClient proxy = new WebClient();
        string homepage = string.Format("http://webstrar6.fulton.asu.edu/");
        Response.Redirect(homepage);
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        WebClient proxy = new WebClient();
        string homepage = string.Format("http://webstrar6.fulton.asu.edu/");
        Response.Redirect(homepage);
    }
}