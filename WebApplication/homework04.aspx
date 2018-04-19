<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homework04.aspx.cs" Inherits="WebApplication.homework04" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            XML Reading<br />
            <br />
            URL for XML (try https://raw.githubusercontent.com/jonnhynick/xml-exercise/master/Hotels.xml)<br />
            <asp:TextBox ID="ResultTextbox" runat="server" Height="16px" Width="573px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="View Root" />
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
