<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Import Namespace ="System.Xml.XPath" %>
<%@ Import Namespace="System.Xml.Xsl" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Enter xml URL
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    Enter xsl URL
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    Enter xsd URL
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Transform to HTML" />
</p>
<p>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="validate" />
</p>
<p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</p>

</asp:Content>
