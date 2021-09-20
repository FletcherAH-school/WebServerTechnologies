<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="Week_2_WST.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="color: #CC00CC">
    <form id="form1" runat="server">
        <asp:Label ID="Label3" runat="server" Text="Welcome back!"></asp:Label>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Height="16px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <asp:Label ID="Label6" runat="server" Text="  Remember me"></asp:Label>
        <p>
            <asp:Button ID="btnEnter" runat="server" Height="43px" OnClick="Button1_Click1" Text="Enter" Width="239px" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="No account?  "></asp:Label>
            <asp:Button ID="btnSignup" runat="server" Text="sign-up here" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Forgot password?  "></asp:Label>
            <asp:Button ID="btnReset" runat="server" Text="reset here" />
        </p>
    </form>
</body>
</html>
