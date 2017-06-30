<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="DadosCliente.aspx.cs" Inherits="pages_DadosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="title text-center">Dados Pessoais</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <br />
            <asp:Label ID="lblNome" runat="server" Text="Nome" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCnpj" runat="server" Text="CPF" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtCNPJ" runat="server"  ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblSexo" runat="server" Text="Sexo" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtSexo" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCidade" runat="server" Text="Cidade" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtCidade" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtEstado" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblDataNascimento" runat="server" Text="Celular" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtDataNascimento" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" ReadOnly="true" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" CssClass="btn btn-default margem" OnClick="btnAlterar_Click"/>
        </div>

        <div class="col-lg-2 qualquer">
            <div class="foto"></div>
        </div>
    </div>

</asp:Content>

