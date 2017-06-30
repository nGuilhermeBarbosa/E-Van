<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="CadastroServiçoMotorista.aspx.cs" Inherits="pages_CadastroServiço" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Cadastro De Serviço</div>
    <div class="row">
        <div class="col-lg-6">
            <br />
            <br />
            <asp:Label ID="lblOrigem" runat="server" Text="Origem" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtOrigem" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDestino" runat="server" Text="Destino" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblLocal" runat="server" Text="Local" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtLocal" runat="server" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <div class="row">
                <div class="col-lg-6">
                    <asp:Label ID="lblData" runat="server" Text="Data" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtData" runat="server" TextMode="Date" CssClass="form-control controle"></asp:TextBox>
                </div>
                <div class="col-lg-6">
                    <asp:Label ID="lblHorario" runat="server" Text="Horário" CssClass="margem"></asp:Label>
                    <asp:TextBox ID="txtHora" runat="server" CssClass="form-control controle"></asp:TextBox>
                </div>
            </div>
            <br />
            <br />
            <asp:Label ID="lblDescricao" runat="server" Text="Descrição" CssClass="margem"></asp:Label>
            <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" CssClass="form-control controle"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-default margem" />

        </div>
    </div>
</asp:Content>

