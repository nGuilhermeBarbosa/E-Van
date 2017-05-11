<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="addRequest.aspx.cs" Inherits="pages_addRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="title text-center">Cadastrar Solicitação</div>
        <div class="col-lg-6 margin">
            <asp:TextBox ID="txtNome" runat="server" placeholder="Nome" CssClass="form-control"></asp:TextBox><br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:TextBox ID="txtCidadeO" runat="server" placeholder="Sua cidade" CssClass="form-control"></asp:TextBox><br />
                </div>
                <div class="col-lg-6">
                    <asp:TextBox ID="Data" runat="server" placeholder="Data" CssClass="form-control" TextMode="date"></asp:TextBox><br />
                </div>
            </div>
            <asp:TextBox ID="txtCidadeD" runat="server" placeholder="Destino" CssClass="form-control"></asp:TextBox><br />
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Número de pessoas" CssClass="form-control" TextMode="number"></asp:TextBox><br />
            <asp:TextBox ID="txtMensagem" runat="server" placeholder="Mensagem" TextMode="multiline" CssClass="form-control"></asp:TextBox><br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success" />
        </div>
    </div>
</asp:Content>

