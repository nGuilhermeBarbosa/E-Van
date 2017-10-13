<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="CompletaCadastro.aspx.cs" Inherits="pages_CompletaCadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="title text-center">Completar Cadastro</div>
    <br />
    <br />
    <br />
    <div class="signupBox">
        <div class="row">
                <div class="col-lg-4">
                    <asp:HiddenField ID="hdf" runat="server" />
                    <asp:Label ID="Telefone" runat="server" Text="Telefone" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddl" runat="server" CssClass="form-control controle">
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6">
                    <br />
                    <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
        <br />
        <br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-info margem" OnClick="btnEnviar_Click" />
    </div>
</asp:Content>

