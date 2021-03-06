﻿<%@ Page Title="Informações de Serviço" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="serviceInfoCliente.aspx.cs" Inherits="pages_serviceInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../js/Imagem.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="myModal" class="moda">

        <!-- The Close Button -->
        <span class="close">&times;</span>

        <!-- Modal Content (The Image) -->
        <img class="moda-content" id="img01">

        <!-- Modal Caption (Image Text) -->
        <div id="caption"></div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="title" style="margin-bottom: 10px;">
                <span class="text-left glyphicon glyphicon-ok rightButton"><a href="pagamento.aspx/id=?">&nbsp;Confirmar Pagamento</a></span>
                Informação do Serviço</div>
            <asp:Literal ID="lInfo" runat="server"></asp:Literal>
        </div>
    </div>
    <div class="row">
        <%--<div class="col-lg-8">--%>
        <asp:Literal ID="LiteralInfo" runat="server"></asp:Literal>
        <%--<div class="title">João</div>
            <div class="serviceBox">
                <div class="title">Serviço</div>
                <div class="padding">
                    Local: Praia Grande
                <br />
                    Origem: Guaratinguetá
                <br />
                    Destino: Ubatuba
                <br />
                </div>
                <p>Data da viagem: 06/07</p>
            </div>

            <div class="serviceBox">
                <div class="title">Contatos</div>
                <div class="padding">
                    Telefone: (12)3152-6361<br />
                    Celular: (12)98162-6478<br />
                    Whatsapp: (12)98162-6478<br />
                    E-Mail: demirvans@outlook.com<br />
                </div>
            </div>

            <div class="serviceBox">
                <div class="title w3">Motorista</div>
                <div class="padding">
                    Nome: João da Silva<br />
                    CNH: 358185016<br />
                </div>
            </div>

            <div class="serviceBox">
                <div class="title">Veículo</div>
                <div class="padding">
                    001<br />
                    Tipo: Van<br />
                    Complementos: Wi-fi<br />
                    Lugares: 15
                    <table>
                        <tr>
                            <td>
                                <div class="photoDriver" style="border: 1px dashed #566787">
                                    Foto ANTT
                                </div>
                            </td>
                            <td>
                                <div class="photoDriver" style="border: 1px dashed #566787">
                                    Foto ARTESP
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
                <p>Lugares Disponíveis: 5/15</p>
            </div>

            <div class="serviceBox info padding Free">
                Você tem interesse nesse serviço?
        <br />
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Sim" />
            </div>--%>
        <%--</div>--%>

        <%--<div class="col-lg-4">
        <div class="title">Fotos do Veículo</div>
        <div class="photoGallery mainPhoto">
        </div>
        <div class="galleryField">
            <div class="photoGallery"></div>
            <div class="photoGallery"></div>
            <div class="photoGallery"></div>
        </div>
    </div>--%>
    </div>
</asp:Content>

