<%@ Page Title="Adicionar Requerimento" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="addRequest.aspx.cs" Inherits="pages_addRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        function openModalSS() {
            $('#fbSS').modal('show');
        }
        function openModalSE() {
            $('#fbSE').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="fbSS" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Cadastro de Solicitação</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Soliticação registrada com sucesso!</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="fbSE" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Cadastro de Solicitação</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-remove col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Erro ao cadastrar a solicitação, por favor verifique os campos e tente novamente!</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="title text-center">
        <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="GerenciamentoSolicitações.aspx">&nbsp;Voltar</a></span>
        Cadastrar Solicitação
    </div>
    <br />
    <br />
    <br />
    <div class="signupBox" style="padding-right: 45px;">
        <div class="row">
            <div class="col-lg-12 margin">
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblOrigem" runat="server" Text="Origem" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                        <asp:TextBox ID="txtOrigem" runat="server" CssClass="form-control"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblDestino" runat="server" Text="Destino" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                        <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control"></asp:TextBox><br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataInicio" runat="server" Text="Data de Partida" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                        <asp:TextBox ID="txtDataInicio" runat="server" CssClass="form-control" TextMode="date"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataFim" runat="server" Text="Data de Retorno" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                        <asp:TextBox ID="txtDataFim" runat="server" CssClass="form-control" TextMode="date"></asp:TextBox><br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblHoraInicio" runat="server" Text="Hora de Partida" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                        <asp:TextBox ID="txtHoraInicio" runat="server" CssClass="form-control" TextMode="time"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblHoraFim" runat="server" Text="Hora de Retorno" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                        <asp:TextBox ID="txtHoraFim" runat="server" CssClass="form-control" TextMode="time"></asp:TextBox><br />
                    </div>
                </div>
                <asp:HiddenField ID="hdf" runat="server" />
                <asp:Label ID="lblVagas" runat="server" Text="Número de Passageiros" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                <asp:TextBox ID="txtPessoas" runat="server" CssClass="form-control" TextMode="number"></asp:TextBox><br />
                <asp:Label ID="lblMensagem" runat="server" Text="Mensagem" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                <asp:TextBox ID="txtMensagem" runat="server" TextMode="multiline" CssClass="form-control" Style="resize: none;"></asp:TextBox><br />

                <div class="serviceBox info padding Free" style="width: 96%; height:50px; padding:10px; text-align:center;">
                    Gostaria de definir este serviço como particular?
                    &nbsp;
                <asp:CheckBox ID="cbl" runat="server" Text="Sim" />
                </div>
                
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnCadastrar_Click" />

                <%--<asp:Label ID="Label2" runat="server" Text="---"></asp:Label>--%>
            </div>
        </div>
    </div>
</asp:Content>

