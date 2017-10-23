<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="Condutores.aspx.cs" Inherits="pages_Condutores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">Meus Condutores
                <span class="text-right glyphicon glyphicon-plus"><a href="addCondutor.aspx">&nbsp;Adicionar Condutor</a></span>
                <asp:Literal ID="ltrCondutores" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
</asp:Content>

