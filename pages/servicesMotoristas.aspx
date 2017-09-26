<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="servicesMotoristas.aspx.cs" Inherits="pages_servicesMotoristas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="title text-center">Serviços</div>
        <div class="col-lg-12">

            <asp:Literal ID="LiteralServices" runat="server" Text="Nenhum serviço disponível no momento"></asp:Literal>

        </div>
    </div>
    <div class="getDown"></div>
</asp:Content>

