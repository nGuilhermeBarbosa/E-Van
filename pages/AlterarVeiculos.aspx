﻿<%@ Page Title="Alterar Veículo" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="AlterarVeiculos.aspx.cs" Inherits="pages_AlterarVeiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="title text-center">Alterar Dados do Veiculo</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblVeiculo" runat="server" Text="Tipo De Veiculo" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlVeiculo" runat="server" CssClass="form-control controle dropdown">
                        
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblModelo" runat="server" Text="Modelo" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblLugar" runat="server" Text="Lugares" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtLugar" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRecursos" runat="server" Text="Recursos" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtRecursos" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblFoto" runat="server" Text="Upload de Fotos: " CssClass="up"></asp:Label>
            <asp:ImageButton ID="imgVeiculo" runat="server" CssClass="up"/>
            <br />
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Salvar" cssclass="btn btn-default margem"/>
            <asp:Button ID="Button1" runat="server" Text="Cancelar" cssclass="btn btn-default margem"/>
        </div>
    </div>
</asp:Content>

