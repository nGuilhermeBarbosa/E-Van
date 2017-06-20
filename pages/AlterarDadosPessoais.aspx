<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="AlterarDadosPessoais.aspx.cs" Inherits="pages_AlterarDadosPessoais" %>

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
                    <asp:Label ID="lblCnpj" runat="server" Text="CNPJ" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtCNPJ" runat="server" CssClass="form-control controle"></asp:TextBox>
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
                    <asp:Label ID="lblEndereco" runat="server" Text="Endereço" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblBairro" runat="server" Text="Bairro" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtBairro" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblComplemento" runat="server" Text="Complemento" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtComplemento" runat="server" CssClass="form-control controle"></asp:TextBox>
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
            <asp:Label ID="lblTelefone" runat="server" Text="Telefone" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCelular" runat="server" Text="Celular" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control controle"></asp:TextBox>
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
            <asp:Button ID="btnUp" runat="server" Text="Upload" CssClass="doc" />
            <asp:Label ID="lblDoc" runat="server" Text="Documento:" CssClass="doc"></asp:Label>
        </div>

    </div>
</asp:Content>

