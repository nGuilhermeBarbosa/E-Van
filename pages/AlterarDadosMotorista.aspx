﻿<%@ Page Title="Alterar dados do Motorista" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="AlterarDadosMotorista.aspx.cs" Inherits="pages_AlterarDadosPessoais" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Alterar Dados Pessoais</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <br />
            <asp:HiddenField ID="hdf" runat="server" />
            <asp:HiddenField ID="hdfID" runat="server" />
            <asp:HiddenField ID="hdfM" runat="server" />
            <asp:Label ID="lblNome" runat="server" Text="Nome" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCNPJ" runat="server" Text="CNPJ" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtCNPJ" runat="server" CssClass="form-control controle" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblSexo" runat="server" Text="Sexo" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control controle">
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblCidade" runat="server" Text="Cidade" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlCidade" runat="server" CssClass="form-control controle" AutoPostBack="true">
                        <asp:ListItem>Lorena</asp:ListItem>
                        <asp:ListItem Selected="True">Guaratinguet&#225;</asp:ListItem>
                        <asp:ListItem>Taubat&#233;</asp:ListItem>
                        <asp:ListItem>Aparecida</asp:ListItem>
                        <asp:ListItem>Canas</asp:ListItem>
                        <asp:ListItem>Pindamonhangaba</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblEstado" runat="server" Text="Estado" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control controle">
                        <asp:ListItem Selected="true">SP</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblData" runat="server" Text="Data de Nascimento" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtData" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="Telefone" runat="server" Text="Telefone" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddl" runat="server" CssClass="form-control controle">
                        <asp:ListItem Value="1">Telefone</asp:ListItem>
                        <asp:ListItem Value="2">Celular</asp:ListItem>
                        <asp:ListItem Value="3">Whatsapp</asp:ListItem>
                        <asp:ListItem Value="4">Email Alternativo</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <br />
                    <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-default margem" OnClick="btnSalvar_Click" />
            <a href="homeCliente.aspx">
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-default margem" /></a>
        </div>
        <div class="col-lg-2 qualquer">
            <div class="foto"></div>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

    </div>
</asp:Content>

