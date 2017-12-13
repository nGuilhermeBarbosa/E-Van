<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="Proposta.aspx.cs" Inherits="pages_Proposta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function openModalS() {
            $('#fbSuccess').modal('show');
            function openModalE() {
                $('#fbError').modal('show');
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="fbSuccess" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Proposta E-Van</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Envio de proposta efetuado com Sucesso</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div id="fbError" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Proposta E-Van</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-remove col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Ocorreu um erro, por favor verifique o campo e tente novamente</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
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
                <asp:Label ID="lblProposta" runat="server" Text="Proposta" CssClass="margem"></asp:Label><span style="color: #ff0000;"></span>
                <asp:TextBox ID="txtProposta" runat="server" CssClass="form-control" Style="resize: none;" onkeyup="formataValor(this, Function);"></asp:TextBox><br />
                <asp:Label ID="Label1" runat="server" Text="---" Visible="false"></asp:Label><br />

                <asp:HiddenField ID="hdf1" runat="server" />
                <asp:Button ID="btnCadastrar" runat="server" Text="Enviar" CssClass="btn btn-success" OnClick="btnCadastrar_Click" />

                <%--<asp:Label ID="Label2" runat="server" Text="---"></asp:Label>--%>
            </div>
        </div>
    </div>

</asp:Content>

