﻿<%@ Page Title="Página inicial Passageiro" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="homeCliente.aspx.cs" Inherits="pages_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-9">
            
            <div class="title">Busca<span id="btnSearch" class="glyphicon glyphicon-search"></span></div>
            <div id="campoBusca" class="col-lg-12" style="display: none;">

                <div class="filtro">
                    Local de Origem<br />
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox><br />
                    Local de Destino<br />
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox><br />
                    Data Prevista<br />
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox><br />
                    Ranking<br />
                    <asp:CheckBox ID="cb1s" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><br />
                    <asp:CheckBox ID="cb2s" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><br />
                    <asp:CheckBox ID="cb3s" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><br />
                    <asp:CheckBox ID="cb4s" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><br />
                    <asp:CheckBox ID="cb5s" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><br />
                    <br />
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info" autopostback="true"/>
                </div>
            </div>
            <br />
            <div class="title">Principais Recomendações</div>

            <asp:Literal ID="LiteralServices" runat="server"></asp:Literal>


        </div>
        <div class="col-lg-3">
            <div class="title">Ranking</div>
            <div class="col-lg-12">
                <div class="serviceBox userAvaliate padding">
                    Nome: João<br />
                    Cidade: Guaratinguetá<br />
                    Avaliação: 5<br />
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star-empty"></div>
                </div>
                <div class="serviceBox userAvaliate padding">
                    Nome: Luis<br />
                    Cidade: Guaratinguetá<br />
                    Avaliação: 5<br />
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star"></div>
                    <div class="glyphicon glyphicon-star-empty"></div>
                </div>
                <asp:Button ID="btnShowAll" runat="server" Text="Ver todas as avaliações" CssClass="btn btn-default buttonShowAll" OnClick="btnShowAll_Click" />
            </div>
        </div>
    </div>
</asp:Content>

