<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="WebApplication5.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name:
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name:
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
           Password:
            <asp:TextBox ID="txtHKey" runat="server" ></asp:TextBox>
            <br />

            <br />
            <asp:Button ID="btnSubmit" runat="server"  Text="Update" OnClick="btnSubmit_Click" />
            <asp:Button ID="Button1" runat="server"  Text="Insert" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server"  Text="Delete" OnClick="DeleteButton_Click" />

            <p>
            <asp:DropDownList ID="ddlUsers" runat="server" AutoPostBack="true"></asp:DropDownList>
                </p>
           </div>
    </form>
</body>
</html>
