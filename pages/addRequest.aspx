<%@ Page Title="Adicionar Requerimento" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="addRequest.aspx.cs" Inherits="pages_addRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Cadastrar Solicitação</div>
    <br />
    <br />
    <br />
    <div class="signupBox">
        <div class="row">
            <div class="col-lg-12 margin">
                <asp:CheckBox ID="cbl" runat="server" Text="Particular" />
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblOrigem" runat="server" Text="Origem" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtOrigem" runat="server" CssClass="form-control"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblDestino" runat="server" Text="Destino" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control"></asp:TextBox><br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataInicio" runat="server" Text="Data de Partida" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtDataInicio" runat="server" CssClass="form-control" TextMode="date"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataFim" runat="server" Text="Data de Retorno" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtDataFim" runat="server" CssClass="form-control" TextMode="date"></asp:TextBox><br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblHoraInicio" runat="server" Text="Hora de Partida" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtHoraInicio" runat="server" CssClass="form-control" TextMode="time"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblHoraFim" runat="server" Text="Hora de Retorno" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtHoraFim" runat="server" CssClass="form-control" TextMode="time"></asp:TextBox><br />
                    </div>
                </div>
                <asp:HiddenField ID="hdf" runat="server" />
                <asp:Label ID="lblVagas" runat="server" Text="Vagas Disponíveis" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtPessoas" runat="server" CssClass="form-control" TextMode="number"></asp:TextBox><br />
                <asp:Label ID="lblMensagem" runat="server" Text="Mensagem" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtMensagem" runat="server" TextMode="multiline" CssClass="form-control" Style="resize: none;"></asp:TextBox><br />
                <asp:Button ID="btnCadastrar" runat="server" Text="Enviar" CssClass="btn btn-success" OnClick="btnCadastrar_Click" />
                
                <%--<asp:Label ID="Label2" runat="server" Text="---"></asp:Label>--%>
            </div>
        </div>
    </div>
</asp:Content>

