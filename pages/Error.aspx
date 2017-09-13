<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Error.aspx.cs" Inherits="pages_Error" %>

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
    <br /><br /><br /><br />
    <div class="getDown"></div>
    <br /><br /><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click"/>
</asp:Content>

