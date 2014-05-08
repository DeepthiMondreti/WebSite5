<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginForm.aspx.cs" Inherits="LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Enter user name</td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Enter password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password "></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Log in" OnClick="btnLogin_Click" />
            </td>
            <td><asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            </td>
            </tr>
            </table>  
            <asp:LinkButton ID="lblRegister" runat="server" PostBackUrl="~/Default.aspx">Register</asp:LinkButton>
    </div>
    </form>
</body>
</html>
