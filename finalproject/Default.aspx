<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="finalproject.Default" MasterPageFile ="~/Site1.Master"%>


<asp:Content runat="server" ID ="signup" ContentPlaceHolderID="ContentPlaceHolder2">
   
        <div class="container">
            Signup
            <br />
            <br />
            User Name:
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <br />
            First Name:
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name:
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
           Password:
            <asp:TextBox ID="txtHKey" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <br />
            <br />
        </div>
</asp:Content>