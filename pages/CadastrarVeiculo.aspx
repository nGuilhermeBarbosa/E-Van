﻿<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="CadastrarVeiculo.aspx.cs" Inherits="pages_CadastrarVeiculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Cadastrar Veiculo</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblVeiculo" runat="server" Text="Tipo De Veiculo" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlVeiculo" runat="server" CssClass="form-control dropdown">
                        
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblModelo" runat="server" Text="Modelo" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control "></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblLugar" runat="server" Text="Lugares" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtLugar" runat="server" CssClass="form-control "></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRecursos" runat="server" Text="Recursos" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtRecursos" runat="server" CssClass="form-control "></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblFoto" runat="server" Text="Upload de Fotos: " CssClass="up"></asp:Label>
            <asp:ImageButton ID="imgVeiculo" runat="server" CssClass="up"/>
            <br />
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" cssclass="btn btn-default margem"/>
        </div>
    </div>
</asp:Content>
