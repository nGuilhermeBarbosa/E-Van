<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="pages_Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <div class="signupBox">
        <h5>Selecione o tipo de conta: </h5>
        <asp:RadioButtonList ID="rbTipoConta" runat="server" OnSelectedIndexChanged="rbTipoConta_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Selected="True">Comum</asp:ListItem>
            <asp:ListItem>Premium</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Panel ID="Free" runat="server" Visible="true">
            A conta comum é fjsalhawofjaslfhadslfasfjasfjxa...
            <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control" placeholder="CPF"></asp:TextBox><br />
            <asp:TextBox ID="txtNascimento" runat="server" CssClass="form-control" TextMode="date"></asp:TextBox><br />
            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success" />
        </asp:Panel>
        <asp:Panel ID="Premium" runat="server" Visible="false">
            Com a conta premium você tem as vantagens de fjdsaifuawojaojfa...
            <asp:TextBox ID="txtCNPJ" runat="server" placeholder="CPNJ" CssClass="form-control"></asp:TextBox><br />
            <asp:Button ID="btnNext" runat="server" Text="Cadastrar" CssClass="btn btn-success" />
        </asp:Panel>
    </div>
    <div class="getDown"></div>
</asp:Content>

