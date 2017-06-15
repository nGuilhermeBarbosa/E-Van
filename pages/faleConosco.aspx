<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="faleConosco.aspx.cs" Inherits="pages_faleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Fale Conosco</div>
    Nome
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" required="required"></asp:TextBox><br />
    E-mail
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
    Mensagem
    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="MultiLine" required="required"></asp:TextBox><br />
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-info" />
    <div class="getDown"></div><br />
</asp:Content>

