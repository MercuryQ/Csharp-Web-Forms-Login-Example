<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginApp.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><b><u>Login Page</u></b></h3>

        </div>
        <p>
            &nbsp;</p>
       
          Username&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="282px" AutoCompleteType="Disabled"></asp:TextBox>
&nbsp;<p>
            Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Width="282px" AutoCompleteType="Disabled"></asp:TextBox>
        </p>
        <p style="margin-left: 160px">
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False" Font-Bold="True" ForeColor="Red"></asp:Label>
        </p>
        <p style="margin-left: 160px">
            <asp:Button ID="Button1" runat="server" Text="Log In" OnClick="Button1_Click" BorderStyle="Outset" BorderColor="" Height="30px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BorderStyle="Outset" OnClick="Button2_Click" Text="New Account?" BorderColor="" Height="30px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
