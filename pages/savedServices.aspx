<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="savedServices.aspx.cs" Inherits="pages_savedServices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row page">
        <div class="col-lg-12">
            <div class="title text-center">
                Serviços Salvos
                <span class="glyphicon glyphicon-trash glyphiconBar">&nbsp;Limpar</span>
            </div>
            <div class="serviceBox">
                <div class="title text-right">
                    <b>João</b>
                    <span class="glyphicon glyphicon-remove">Remover</span>
                </div>
                <div class="padding">
                    <table border="0">
                        <tr>
                            <td>
                                <b>Destino:&nbsp</b>Praia Grande<br />
                                <b>Cidade:&nbsp</b>Ubatuba<br />
                                <b>Saída:&nbsp</b>Guaratinguetá<br />
                            </td>
                            <td>
                                <div class="photoDriver border"></div>
                            </td>
                        </tr>
                    </table>
                </div>
                <p>9/5/2017</p>
            </div>

        </div>
    </div>
    <div class="getDown"></div>
</asp:Content>
