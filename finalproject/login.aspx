<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="finalproject.login" MasterPageFile ="~/Site1.Master" %>

<asp:Content runat="server" ID ="login" ContentPlaceHolderID="ContentPlaceHolder3">


        <div class="container">
            Log-in
    <br />
    <br />
            User Name:
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>


            <br />
            <br />

            Password:
            <asp:TextBox ID="txtHKey" runat="server"></asp:TextBox>


            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server"  Text="Enter" OnClick="btnLogin_Click" />
            <br />
            <br />
            
        </div>  

</asp:Content>  