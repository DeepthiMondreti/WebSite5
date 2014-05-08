<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome would you like to donate</h1>
        <table>
       <tr>
            <td>Enter your donation</td>
            <td>
                <asp:TextBox ID="txtDonation" runat="server"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDonation" ErrorMessage="Must be a valid number" Operator="DataTypeCheck" Type="Double" Display="None"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDonation" Display="None" ErrorMessage="Must enter a donation"></asp:RequiredFieldValidator>
            </td>
      </tr>
      <tr>
            <td>
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnLogin_Click" />
            </td>
            <td><asp:Label ID="lblError1" runat="server" Text="Label"></asp:Label>
            </td>
       </tr>
       </table>
    </div>
    </form>
</body>
</html>
