<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="pages_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <div class="loginBox">
        <asp:TextBox ID="txtEmail" type="Email" runat="server" placeholder="E-Mail" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="txtSenha" type="Password" runat="server" placeholder="Senha" CssClass="form-control"></asp:TextBox><br />
        <asp:Label ID="lbl" runat="server" Text="" CssClass="alert-danger" Visible="false"></asp:Label>
        <asp:Button ID="btnEnviar" runat="server" Text="Entrar" CssClass="btn btn-info form-control" OnClick="btnEnviar_Click" />
        <a href="#">Esqueci a senha</a>
    </div>
</asp:Content>

