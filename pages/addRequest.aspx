<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="addRequest.aspx.cs" Inherits="pages_addRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Cadastrar Solicitação</div>
    <br /><br /><br />
    <div class="signupBox">
        <div class="row">
            <div class="col-lg-12 margin">
                <asp:TextBox ID="txtNome" runat="server" placeholder="E-Mail" CssClass="form-control"></asp:TextBox><br />
                <div class="row">
                    <div class="col-lg-12">
                        <asp:TextBox ID="txtCidadeO" runat="server" placeholder="Sua cidade" CssClass="form-control"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-12">
                        <asp:TextBox ID="Data" runat="server" placeholder="Data" CssClass="form-control" TextMode="date"></asp:TextBox><br />
                    </div>
                </div>
                <asp:TextBox ID="txtCidadeD" runat="server" placeholder="Destino" CssClass="form-control"></asp:TextBox><br />
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Número de pessoas" CssClass="form-control" TextMode="number"></asp:TextBox><br />
                <asp:TextBox ID="txtMensagem" runat="server" placeholder="Mensagem" TextMode="multiline" CssClass="form-control"></asp:TextBox><br />
                <asp:Button ID="btnCadastrar" runat="server" Text="Enviar" CssClass="btn btn-success" OnClick="btnCadastrar_Click"/>
                <asp:Label ID="Label1" runat="server" Text="---"></asp:Label><br />
                <asp:Label ID="Label2" runat="server" Text="---"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

