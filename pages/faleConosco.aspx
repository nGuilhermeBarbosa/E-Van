<%@ Page Title="Fale Conosco" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="faleConosco.aspx.cs" Inherits="pages_faleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        function openModalCb() {
            $('#fbCb').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="fbCb" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Fale Conosco</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Mensagem enviada com sucesso!</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="title text-center">Fale Conosco</div>
    <br />
    <br />
    <br />
    <div class="signupBox">
        Nome
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" required="required"></asp:TextBox><br />
        E-mail
    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
        Mensagem
    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="MultiLine" required="required"></asp:TextBox><br />
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-info" OnClick="btnEnviar_Click" />
        <asp:Label ID="lblFeedBack" runat="server" Text=""></asp:Label>
    </div>
    <br />
</asp:Content>

