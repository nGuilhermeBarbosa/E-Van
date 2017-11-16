﻿<%@ Page Title="Cadastrar Veículo" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="CadastrarVeiculo.aspx.cs" Inherits="pages_CadastrarVeiculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">
        <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="TodosVeiculos.aspx">&nbsp;Voltar</a></span>
        Cadastrar Veículo
    </div>
    <br />
    <br />
    <br />
    <div class="row">
        <div class="signupBox">
            <br />
            <br />
            <div class="col-lg-4">
                <asp:Label ID="lblVeiculo" runat="server" Text="Tipo De Veiculo" CssClass="margem"></asp:Label>
                <asp:DropDownList ID="ddlVeiculo" runat="server" CssClass="form-control controle dropdown">
                </asp:DropDownList>
            </div>
            <div class="col-lg-8">
                <asp:Label ID="lblModelo" runat="server" Text="Modelo" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control controle"></asp:TextBox>
            </div>

            <br />
            <asp:Label ID="lblLugar" runat="server" Text="Lugares" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtLugar" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <asp:Label ID="lblRecursos" runat="server" Text="Recursos" CssClass="margem"></asp:Label>
            <asp:CheckBoxList ID="cblRecursos" runat="server" CssClass="checkbox box">
                <asp:ListItem Value="1">Ar-condicionado</asp:ListItem>
                <asp:ListItem Value="2">Wi-fi</asp:ListItem>
                <asp:ListItem Value="3">Televis&#227;o</asp:ListItem>
                <asp:ListItem Value="4">Frigobar</asp:ListItem>
                <asp:ListItem Value="5">R&#225;dio</asp:ListItem>
                <asp:ListItem Value="6">Porta Autom&#225;tica</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="lblFoto" runat="server" Text="Upload de Fotos: " CssClass="up"></asp:Label>
            <asp:ImageButton ID="imgVeiculo" runat="server" CssClass="up" />
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-default margem" />
        </div>
    </div>
</asp:Content>

