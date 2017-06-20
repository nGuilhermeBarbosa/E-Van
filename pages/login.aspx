<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="pages_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br />
    <div class="loginBox">
        <asp:TextBox ID="txtEmail" type="Email" runat="server" placeholder="E-Mail" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="txtSenha" type="Password" runat="server" placeholder="Senha" CssClass="form-control"></asp:TextBox><br />
        <asp:Button ID="btnEnviar" runat="server" Text="Entrar" CssClass="btn btn-info form-control"/>
        <a href="#">Esqueci a senha</a>
        
    </div>
    <br /><br /><br /><br /><div class="getDown"></div>
</asp:Content>

