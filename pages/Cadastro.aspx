<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="pages_Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <div class="signupBox">
        <h5>Selecione o tipo de conta: </h5>
        <asp:RadioButtonList ID="rbTipoConta" runat="server" OnSelectedIndexChanged="rbTipoConta_SelectedIndexChanged">
            <asp:ListItem Selected="True">Gratuita</asp:ListItem>
            <asp:ListItem>Premium</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Panel ID="Free" runat="server" Visible="true">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" />
        </asp:Panel>
        <asp:Panel ID="Premium" runat="server" Visible="false">
            <h3>Serviço Indisponível</h3>
        </asp:Panel>
    </div>
</asp:Content>

