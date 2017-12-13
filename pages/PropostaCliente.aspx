<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="PropostaCliente.aspx.cs" Inherits="pages_PropostaCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">
        <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="GerenciamentoSolicitações.aspx">&nbsp;Voltar</a></span>
        Informações da Solicitação
    </div>
    <br />
    <br />
    <br />
    <div class="signupBox" style="padding-right: 45px;">
        <div class="row">
            <div class="col-lg-12 margin">
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblOrigem" runat="server" Text="Origem" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                        <asp:TextBox ID="txtOrigem" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblDestino" runat="server" Text="Destino" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                        <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox><br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataInicio" runat="server" Text="Data e Horário de Partida" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                        <asp:TextBox ID="txtDataInicio" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataFim" runat="server" Text="Data e Horário de Retorno" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                        <asp:TextBox ID="txtDataFim" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox><br />
                    </div>
                </div>
                <%--<div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblHoraInicio" runat="server" Text="Hora de Partida" CssClass="margem"></asp:Label><span style="color: #ff0000;"> *</span>
                        <asp:TextBox ID="txtHoraInicio" runat="server" CssClass="form-control" ReadOnly="true" ></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblHoraFim" runat="server" Text="Hora de Retorno" CssClass="margem"></asp:Label><span style="color: #ff0000;"> *</span>
                        <asp:TextBox ID="txtHoraFim" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox><br />
                    </div>
                </div>--%>
                <asp:HiddenField ID="hdf" runat="server" />
                <asp:Label ID="lblVagas" runat="server" Text="Número de Passageiros" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                <div class="row">
                    <div class="col-lg-4">
                        <asp:TextBox ID="txtPessoas" runat="server" CssClass="form-control" TextMode="number" ReadOnly="true"></asp:TextBox><br />
                    </div>
                </div>
                <asp:Label ID="lblMensagem" runat="server" Text="Descrição" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                <asp:TextBox ID="txtMensagem" runat="server" TextMode="multiline" CssClass="form-control" Style="resize: none;" ReadOnly="true"></asp:TextBox><br />
                <asp:Label ID="Label1" runat="server" Text="---" Visible="false"></asp:Label><br />

                <asp:Label ID="lblNomeM" runat="server" Text="Nome do Motorista" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                <asp:TextBox ID="txtNomeM" runat="server" CssClass="form-control" Style="resize: none;" ReadOnly="true"></asp:TextBox><br />
                <div class="row">
                    <div class="col-lg-4">
                        <asp:Label ID="lblTContato" runat="server" Text="Tipo de Contato" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                        <asp:TextBox ID="txtTContato" runat="server" CssClass="form-control" Style="resize: none;" ReadOnly="true"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-8">
                        <asp:Label ID="lblContato" runat="server" Text="Telefone" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                        <asp:TextBox ID="txtContato" runat="server" CssClass="form-control" Style="resize: none;" ReadOnly="true"></asp:TextBox><br />
                    </div>
                </div>
                <asp:Label ID="lblProposta" runat="server" Text="Proposta do Motorista" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                <asp:TextBox ID="txtProposta" runat="server" CssClass="form-control" Style="resize: none;" ReadOnly="true"></asp:TextBox><br />

                <asp:HiddenField ID="hdf1" runat="server" />
                <%--<asp:Label ID="Label2" runat="server" Text="---"></asp:Label>--%>
            </div>
        </div>
    </div>
</asp:Content>

