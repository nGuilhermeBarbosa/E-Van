<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="allAdmin.aspx.cs" Inherits="pages_allAdmin" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="title text-center">
            Todos Administradores
            <span class="glyphicon glyphicon-plus glyphiconBar">&nbsp;<a href="addAdmin.aspx">Adicionar Administrador</a></span>
        </div>

        <div class="col-lg-9" style="float:left;">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
        <div class="col-lg-3" style="float:right;">
            <p class="glyphicon glyphicon-trash"></p>
            <asp:DropDownList ID="ddlAdmin" runat="server" OnSelectedIndexChanged="ddlAmdmin_SelectedIndexChanged" AutoPostBack="true" CssClass="form-inline" style="margin-top:10px;"></asp:DropDownList><br />
            <p class="glyphicon glyphicon-edit"></p>
            <asp:DropDownList ID="DropDownListEdit" runat="server" OnSelectedIndexChanged="DropDownListEdit_SelectedIndexChanged" AutoPostBack="true" CssClass="form-inline" style="margin-top:10px;"></asp:DropDownList>
        </div>
        <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
        

    </div>
    <div class="getDown"></div><br />
    <div class="getDown"></div>
</asp:Content>

