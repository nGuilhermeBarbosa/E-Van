﻿<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="addAdmin.aspx.cs" Inherits="pages_addAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Novo Administrador</div>
    <div class="row margem">

        <div class="col-lg-6 margin-left">
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                </div>
                <div class="col-lg-6">
                    <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True" Value="null">Sexo</asp:ListItem>
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-12">
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                </div>
            </div>

            <div class="row">
                <div class="col-lg-6">
                    <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                    <asp:Label ID="lblCS" runat="server" Text="---" Visible="false" CssClass="alert-danger"></asp:Label><br />
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtConfirmarSenha" runat="server" placeholder="Confirme a Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                </div>
            </div>
            <asp:TextBox ID="dataNasc" runat="server" placeholder="Data de Nascimento" CssClass="form-control" TextMode="Date" required="required"></asp:TextBox><br />

            <div class="row">
                <div class="col-lg-6">
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control dropdown">
                        <asp:ListItem Selected="True" Value="null">Estado...</asp:ListItem>
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
            <br />
            <div class="row">
                <div class="center">
                    <asp:Button ID="Button1" runat="server" Text="Cancelar" CssClass="btn btn-danger" />
                    <asp:Button ID="Button2" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnConfirmaCadastro_Click" />
                    <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
            <br />
            <asp:Label ID="lblTeste" runat="server" Text="Cadastro Efetuado"></asp:Label>
            

        </div>
    </div>
</asp:Content>

