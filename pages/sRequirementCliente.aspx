<%@ Page Title="Requerimentos" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="sRequirementCliente.aspx.cs" Inherits="pages_sRequirement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">
                Solicitações
            </div>
            <asp:Literal ID="LSolicitacao" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>
