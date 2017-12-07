<%@ Page Title="Mensagens" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="mensagem.aspx.cs" Inherits="pages_mensagem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">
                Mensagens
                <button id="btnLimpar" type="button" onclick="openModal();" class="glyphicon glyphicon-trash glyphiconBar isntabutton gbbf">&nbsp;Limpar</button>
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
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>

