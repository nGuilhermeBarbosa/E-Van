<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="addCondutor.aspx.cs" Inherits="pages_addCondutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">
                <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="Condutores.aspx">&nbsp;Voltar</a></span>
                Adicionar Condutor
            </div>
            <br />
            <br />
            <div class="signupBox" style="margin-top:20px;">
                Nome:&nbsp;<asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" CssClass="form-control" required="true"></asp:TextBox>
                Nome:&nbsp;<asp:TextBox ID="TextBox1" runat="server" placeholder="Nome Completo" CssClass="form-control" required="true"></asp:TextBox>
            </div>

        </div>
    </div>
</asp:Content>

