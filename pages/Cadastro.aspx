<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="pages_Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title">
        Seleção de Plano
    </div>
    <br />
    <br />
    <br />
    <div class="signupBox">
        <h5>Selecione o tipo de conta</h5>
        <asp:DropDownList ID="ddlTipoConta" runat="server" OnSelectedIndexChanged="ddlTipoConta_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
            <asp:ListItem Selected="True" Value="1">Comum</asp:ListItem>
            <asp:ListItem Value="2">Premium</asp:ListItem>
        </asp:DropDownList>
        <hr />
        <asp:Panel ID="Free" runat="server" Visible="true">
            A conta comum é totalmente gratuita, e não requer nenhum tipo de transação financeira para ser utilizada.
            <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control" placeholder="CPF"></asp:TextBox><br />
            <asp:TextBox ID="txtNascimento" runat="server" CssClass="form-control" TextMode="date"></asp:TextBox><br />
            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success" />
        </asp:Panel>
        <asp:Panel ID="Premium" runat="server" Visible="false">
            A contra premium oferece prioridade na divulgação do seu serviço.
            <div class="plano">Mensal</div>
            <div class="plano">Semanal</div>
        </asp:Panel>
    </div>
    <div class="getDown"></div>
</asp:Content>

