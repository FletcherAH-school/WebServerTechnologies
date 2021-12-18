<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="finalproject.admin" %>

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
           User Type:
            <asp:TextBox ID="txtUserType" runat="server" ></asp:TextBox>
            <br />
            <br />
            User Name:
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <br />
            User Email:
            <asp:TextBox ID="txtUserEmail" runat="server"></asp:TextBox>
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
            <p>
                <asp:GridView ID="gvUsers" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </p>
           </div>
    </form>
</body>
</html>
