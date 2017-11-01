<%@ Page Title="Página inicial Motorista" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="homeMotorista.aspx.cs" Inherits="pages_homeMotorista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lbl" runat="server"></asp:Label>
    <%--<div class="popup">Para a utilização completa do sistema complete o seu cadastro <a href="#">Aqui</a> </div>--%>
    <asp:HiddenField ID="hdf" runat="server" />
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
                    <asp:CheckBox ID="CheckBox1" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><br />
                    <asp:CheckBox ID="CheckBox2" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><br />
                    <asp:CheckBox ID="CheckBox3" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><br />
                    <asp:CheckBox ID="CheckBox4" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><br />
                    <asp:CheckBox ID="CheckBox5" runat="server" />&nbsp;<div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><div class="glyphicon glyphicon-star"></div><br />
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
                <asp:Button ID="btnShowAll" runat="server" Text="Ver todas as avaliações" CssClass="btn btn-default buttonShowAll" />
            </div>
        </div>
    </div>

</asp:Content>

