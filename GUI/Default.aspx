<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GUI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 387px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        Part 2<br />
        <br />
        Hotels XSD = https://raw.githubusercontent.com/jonnhynick/xml-exercise/master/Hotels.xsd<br />
        Hotels XML = https://raw.githubusercontent.com/jonnhynick/xml-exercise/master/Hotels.xml<br />
        <br />
        <br />
        XML validation<br />
        xml file URL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; XSD file URL<br />
        <asp:TextBox ID="XMLTextbox" runat="server" Width="425px"></asp:TextBox>
        <asp:TextBox ID="XSDTextbox" runat="server" Width="426px"></asp:TextBox>
        <asp:Button ID="ValidationSubmit" runat="server" OnClick="ValidationSubmit_Click" Text="Submit" />
        <br />
        <asp:Label ID="ResultValidation" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        XPath Search<br />
        xml file URL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; XPath expression eg. (/Hotels/Hotel)<br />
        <asp:TextBox ID="XMLTextboxSearch" runat="server" Width="425px"></asp:TextBox>
        <asp:TextBox ID="ExpressionTextbox" runat="server" Width="188px"></asp:TextBox>
        <asp:Button ID="XPathSubmit" runat="server" OnClick="XPathSubmit_Click" Text="Submit" />
        <br />
        <asp:Label ID="XPathResult" runat="server"></asp:Label>
    </form>
</body>
</html>
