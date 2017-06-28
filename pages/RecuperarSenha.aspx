<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="RecuperarSenha.aspx.cs" Inherits="pages_RecuperarSenha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="title text-center">Recuperar Senha</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <div class="row">
                <div class="col-lg-7">
                    E-mail: <asp:TextBox ID="txtEmailRec" runat="server" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox>
                    <asp:button ID="RecConta" runat="server" text="Enviar E-mail" cssClass="btn btn-lg"  />
                </div>
            </div>

        </div>
    </div>


</asp:Content>

