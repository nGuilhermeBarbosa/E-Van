﻿<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="pages_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- Body -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="https://placehold.it/1200x400?text=IMAGE" alt="Image">
                <div class="carousel-caption">
                    <h3>Você motorista</h3>
                    <p>Divulgue seu serviço</p>
                </div>
            </div>

            <div class="item">
                <img src="https://placehold.it/1200x400?text=Another Image Maybe" alt="Image">
                <div class="carousel-caption">
                    <h3>More Sell $</h3>
                    <p>Lorem ipsum...</p>
                </div>
            </div>
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

    <div class="container text-center">
        <div class="row">
            <div class="col-sm-6">
                <h3 class="text-left">Encontre o transporte ideal para você agora mesmo!</h3>
            </div>
            <br />
            <div class="col-sm-6">
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Nome Completo" CssClass="form-control" required="required"></asp:TextBox><br />
                <asp:TextBox ID="TextBox2" runat="server" placeholder="E-Mail" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                <asp:TextBox ID="TextBox3" runat="server" placeholder="Senha" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="dropdown form-control">
                    <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Feminino</asp:ListItem>
                </asp:DropDownList><br />
                <div class="row">
                    <div class="col-sm-8">
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control dropdown">
                            <asp:ListItem Selected="True" Value="null">Cidade</asp:ListItem>
                            <asp:ListItem>Lorena</asp:ListItem>
                            <asp:ListItem>Guaratinguetá</asp:ListItem>
                            <asp:ListItem>Taubaté</asp:ListItem>
                            <asp:ListItem>Aparecida</asp:ListItem>
                            <asp:ListItem>Canas</asp:ListItem>
                            <asp:ListItem>Pindamonhangaba</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-sm-4">
                        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control dropdown">
                            <asp:ListItem Selected="True">SP</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-9">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Li e concordo com os Termos de Uso." CssClass="checkbox" />
                    </div>
                    <div class="col-sm-2">
                        <asp:Button ID="Button1" runat="server" Text="Cadastrar" CssClass="btn btn-info" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br>
</asp:Content>
