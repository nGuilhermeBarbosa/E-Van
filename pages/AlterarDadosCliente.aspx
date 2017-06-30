<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="AlterarDadosCliente.aspx.cs" Inherits="pages_AlterarDadosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Alterar Dados Pessoais</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <br />
            <asp:Label ID="lblNome" runat="server" Text="Nome" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCPF" runat="server" Text="CNPJ" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblSexo" runat="server" Text="Sexo" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtSexo" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCidade" runat="server" Text="Cidade" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtCidade" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-default margem" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default margem" />
        </div>
        <div class="col-lg-2 qualquer">
            <div class="foto"></div>
        </div>

    </div>
</asp:Content>

