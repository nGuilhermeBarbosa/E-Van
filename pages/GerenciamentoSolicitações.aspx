<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="GerenciamentoSolicitações.aspx.cs" Inherits="pages_r_management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row page">
        <div class="col-lg-12">
            <div class="title text-center">
                Gerencimento de Solicitações
                <span class="glyphicon glyphicon-plus glyphiconBar"><a href="addRequest.aspx">&nbsp;Adicionar</a></span>
            </div>
            <asp:HiddenField ID="hdf" runat="server" />
            <asp:Literal ID="LSolicitacao" runat="server"></asp:Literal>

        </div>
    </div>
</asp:Content>

