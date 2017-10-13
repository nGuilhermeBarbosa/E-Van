<%@ Page Title="Todos os Usuários" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="TodosMotoristasCliente.aspx.cs" Inherits="pages_TodosMotoristasCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">Principais Motoristas</div>
            <asp:Literal ID="LiteralMotoristas" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>

