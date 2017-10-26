<%@ Page Title="Página inicial Passageiro" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="homeCliente.aspx.cs" Inherits="pages_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-9">
            
            <div class="title">Busca</div>
            <div class="filtro">
                <br />
                <br />
                Sua Cidade
               
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox><br />
                Para onde deseja ir?
               
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox><br />
                Quando quer ir?
               
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox><br />
                Avaliação do Motorista
               
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
                <asp:Button ID="btnShowAll" runat="server" Text="Ver todas as avaliações" CssClass="btn btn-default buttonShowAll" OnClick="btnShowAll_Click" />
            </div>
        </div>
    </div>
</asp:Content>

