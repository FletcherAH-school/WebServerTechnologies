<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="QueryCookieSession.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="FirstName" runat="server" Text="First Name : "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" OnTextChanged="txtUsername_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LastName" runat="server" Text="Last Name : "></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="password" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <p>
            <asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" Text="enter" />
        </p>
    </form>
</body>
</html>
