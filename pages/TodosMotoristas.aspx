<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="TodosMotoristas.aspx.cs" Inherits="pages_TodosMotoristas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">Todos Motoristas</div>
            <asp:Literal ID="LiteralMotoristas" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>

