<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="servicesCliente.aspx.cs" Inherits="pages_services" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="title text-center">Serviços</div>
        <div class="col-lg-12">
            
                <asp:Literal ID="LiteralServices" runat="server"></asp:Literal>
            
        </div>
    </div>
    <div class="getDown"></div>
</asp:Content>

