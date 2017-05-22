<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="TodosServicosMotorista.aspx.cs" Inherits="pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row">
        <div class="col-lg-12">
            <div class="serviceBox">
                <div class="title text-right">
                    <span class="glyphicon glyphicon-edit">Editar</span>
                    <span class="glyphicon glyphicon-remove">Excluir</span>
                </div>
                <div class="fotoveiculo"></div>
                Local de Chegada: 
        <asp:Label ID="lblTipo" runat="server" Text="---"></asp:Label>
                <br />
                Origem:
        <asp:Label ID="lblModelo" runat="server" Text="---"></asp:Label>
                <br />
                Destino: 
        <asp:Label ID="lblLugares" runat="server" Text="---"></asp:Label>
                <br />
                <p>05/17</p>
            </div>
        </div>
    </div>
</asp:Content>

