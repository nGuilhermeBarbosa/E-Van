<%@ Page Title="You're not suppose to being here :/" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Error.aspx.cs" Inherits="pages_Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br />
    <div class="signupBox">
        <div class="title">
            Acesso Negado!
        </div>
        Lamentamos o inconveniente, mas você não possui permissão para acessar essa página, 
        agradescemos a compreensão.
    </div>
    <asp:Button ID="Button1" runat="server" Text="Press me" onclick="Button1_Click" CssClass="btn btn-danger"/>
</asp:Content>

