<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="pages_about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Sobre a Plataforma</div>
    <br />
    <br />
    <br />
    <div class="signupBox text-center">
        Vídeo de apresentação da plataforma
        <hr />
        <video width="500" controls>
            <source src="../video/about.ogg" type="video/mp4">
        </video>
        <hr />
        <p>Reservamos este vídeo para explicar de forma simples e clara o funcionamento da plataforma,
        caso haja qualquer dúvida por favor visitar a página de <a href = "help.aspx">ajuda</a> ou
        <a href="faleConosco.aspx">entrar em contato conosco</a>.</p>
    </div>
</asp:Content>

