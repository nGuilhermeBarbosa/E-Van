<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="addAdmin.aspx.cs" Inherits="pages_addAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="title text-center">Novo Administrador</div>
    <div class="row margem">

        <div class="col-lg-6 margin-left">
            <br />
            <div class="row">
                <div class="col-lg-7">
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-5">
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Nome de Usuário" CssClass="form-control" required="required"></asp:TextBox><br />
                </div>
            </div>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtConfirmarSenha" runat="server" placeholder="Confirme a Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <asp:TextBox ID="txtCpf" runat="server" placeholder="CPF" CssClass="form-control" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="dataNasc" runat="server" placeholder="Data de Nascimento" CssClass="form-control" TextMode="Date" required="required"></asp:TextBox><br />
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6">
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control dropdown">
                        <asp:ListItem Selected="True" Value="null">Estado...</asp:ListItem>
                        <asp:ListItem>ES</asp:ListItem>
                        <asp:ListItem>MG</asp:ListItem>
                        <asp:ListItem>RJ</asp:ListItem>
                        <asp:ListItem>SP</asp:ListItem>
                    </asp:DropDownList><br />
                </div>
                <div class="col-lg-6">
                    <asp:DropDownList ID="ddlCidade" runat="server" CssClass="form-control dropdown">
                        <asp:ListItem Selected="True" Value="null">Cidade...</asp:ListItem>
                        <asp:ListItem>Aparecida</asp:ListItem>
                        <asp:ListItem>Guaratinguetá</asp:ListItem>
                        <asp:ListItem>Lorena</asp:ListItem>
                        <asp:ListItem>São José dos Campos</asp:ListItem>
                        <asp:ListItem>Taubaté</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="center">
                    <asp:Button ID="Button1" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelaCadastro_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnConfirmaCadastro_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

