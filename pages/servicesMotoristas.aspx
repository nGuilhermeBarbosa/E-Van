<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="servicesMotoristas.aspx.cs" Inherits="pages_servicesMotoristas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="title text-center">Serviços</div>
        <div class="col-lg-12">

            <asp:Literal ID="LiteralServices" runat="server" Text="Nenhum serviço disponível no momento"></asp:Literal>

            <!--
            <a href="serviceInfo.aspx" class="dblock">
                <div class="serviceBox">
                    <div class="title">João</div>
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
                -->
        </div>
    </div>
    <div class="getDown"></div>
</asp:Content>

