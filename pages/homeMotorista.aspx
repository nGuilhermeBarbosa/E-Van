<%@ Page Title="Página inicial Motorista" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="homeMotorista.aspx.cs" Inherits="pages_homeMotorista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lbl" runat="server"></asp:Label>
    <%--<div class="popup">Para a utilização completa do sistema complete o seu cadastro <a href="#">Aqui</a> </div>--%>
    <asp:HiddenField ID="hdf" runat="server" />
    <div class="row">
        <div class="col-lg-9">
            <div class="title">Busca</div>
            <div class="filtro">
                <br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Sua cidade"></asp:TextBox><br />
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Para onde deseja ir?"></asp:TextBox><br />
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Quando quer ir?"></asp:TextBox><br />
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                    <asp:ListItem Value="null">Nível de avaliação do motorista</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem Value="6">Exibir todas as op&#231;&#245;es</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-info" />
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

