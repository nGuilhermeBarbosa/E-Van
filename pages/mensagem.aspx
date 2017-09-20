<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="mensagem.aspx.cs" Inherits="pages_mensagem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">
                Mensagens
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="glyphicon glyphicon-trash glyphiconBar gbbf" OnClick="limpar_Click">&nbsp;Limpar</asp:LinkButton>
            </div>

            <!-- Modal -->
            <div id="ModalLimpar" class="modal fade" role="dialog">
                <div class="modal-dialog mdleft">

                    <div class="modal-content">
                        <div class="modal-header">
                            <div class="close" data-dismiss="modal">&times;</div>
                            <h4 class="modal-title">Atenção</h4>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <p>Tem deseja se deseja excluir todas as mensagens?</p>
                                    <p>Esta ação não poderá ser desfeita!</p>
                                    <br />
                                    <asp:Button ID="btnConfirmaExclusao" runat="server" Text="Sim, Excluir" CssClass="btn btn-danger" OnClick="btnConfirmaExclusao_Click" />
                                    <asp:Button ID="btnCancelar" runat="server" Text="Não, Cancelar" OnClick="btnCancelar_Click" CssClass="btn btn-default" />
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

            <script type="text/javascript">
                function openModal() {
                    $('#ModalLimpar').modal('show');
                }
            </script>
            <asp:Literal ID="msg" runat="server"></asp:Literal>

            <!--
            <div class="serviceBox">
                <div class="title">
                    <span class="glyphicon glyphicon-remove">&nbsp;Excluir</span>
                    <span class="glyphicon glyphicon-send">&nbsp;Responder</span>
                </div>
                <div class="padding">
                    <b>Nome: </b>Cunha<br />
                    <b>E-mail: </b>cunhafjg@gmail.com<br />
                    <b>Mensagem: </b>Gostaria de saber se serei notificado se um serviço que eu denunciei foi removido.
                </div>
                <p>24/05/2017</p>
            </div>

            <div class="serviceBox">
                <div class="title">
                    <span class="glyphicon glyphicon-remove">&nbsp;Excluir</span>
                    <span class="glyphicon glyphicon-send">&nbsp;Responder</span>
                </div>
                <div class="padding">
                    <b>Nome: </b>Cunha<br />
                    <b>E-mail: </b>cunhafjg@gmail.com<br />
                    <b>Mensagem: </b>Gostaria de saber se serei notificado se um serviço que eu denunciei foi removido.
                </div>
                <p>24/05/2017</p>
            </div>-->
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <div class="getDown"></div>
</asp:Content>

