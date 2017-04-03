<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Home Page</asp:LinkButton>
    </p>
    <h2>
        <strong>Elective Services:</strong>
    </h2>
    <h4>
        Yelp-based Service:
    </h4>
    <p>
        This service uses Yelp API. It allows user to get the name, phone number and street address of the nearst 3 restaurants based on type food (ex: tacos, pizza, pita, ..)</p>
    <p>
        Input: getLocation(string term, string zipcode)
    </p>
    <p>
        output: string {restaurant1 / phone1 / address 1} {restaurant2 / phone2 /address2} {restaurant3/ phone3 / address3}</p>
    <p>
        Service URL:&nbsp; <a href="http://webstrar6.fulton.asu.edu/page3/Service1.svc">http://webstrar6.fulton.asu.edu/page3/Service1.svc</a></p>
    <p>
        &nbsp;</p>
    <p>
        <br />
        What are you hungry for?
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Enter zipcode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Find</asp:LinkButton>
    </p>
    <p>
        &nbsp;</p>
<p>
        &nbsp;</p>
<h4>
        Binding Energy Service: </h4>
<p>
        This service returns the binding energy of an atomic nucleus from its its number of protons and neutrons. This method is known as the Liquid drope model, and it&#39;s highly used in nuclear and particle physics. </p>
    <p>
        input: bindingEnergy(Int32 A, Int32 Z)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; where A is the mass number (neutrons + protons) and Z is the atomic number (number of protons)</p>
    <p>
        output: double binding energy. </p>
    <p>
        Service URL: <a href="http://webstrar6.fulton.asu.edu/page7/Service1.svc">http://webstrar6.fulton.asu.edu/page7/Service1.svc</a></p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
        Enter the mass number A&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
<p>
        Enter the atomic number Z&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
<p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calculate Binding Energy " />
    </p>
<p>
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Home Page</asp:LinkButton>
    </p>

</asp:Content>
