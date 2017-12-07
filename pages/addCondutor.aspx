<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="addCondutor.aspx.cs" Inherits="pages_addCondutor" %>

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
                    <h4 class="modal-title">Cadastro de Condutor</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Condutor registrado com sucesso!</p>
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
                    <h4 class="modal-title">Cadastro de Condutor</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-remove col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Erro ao cadastrar um condutor, por favor verifique os campos e tente novamente!</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="row">
        <asp:HiddenField ID="hdf1" runat="server" />
        <div class="col-lg-12">
            <div class="title">
                <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="Condutores.aspx">&nbsp;Voltar</a></span>
                Adicionar Condutor
            </div>
            <br />
            <br />
            <div class="signupBox" style="margin-top: 20px;">
                <span style="color:#ff0000;">* </span>Nome&nbsp;<asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" CssClass="form-control" required="true" MaxLength="50"></asp:TextBox><br />
                <span style="color:#ff0000;">* </span>CPF&nbsp;<asp:TextBox ID="txtCPF" runat="server" placeholder="CPF" CssClass="form-control" required="true" onkeyup="formataCPF(this,event);" MaxLength="14"></asp:TextBox><br />
                <div class="row">
                    <div class="col-lg-3"><span style="color:#ff0000;">* </span>Tipo de Contato&nbsp;
                        <asp:DropDownList ID="ddl" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddl_SelectedIndexChanged" AutoPostBack="true">
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-9">
                        <span style="color:#ff0000;">* </span>Contato&nbsp;
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" CssClass="form-control" required="true" Visible="false"></asp:TextBox>
                        <asp:TextBox ID="txtTelefone" runat="server" placeholder="Telefone" CssClass="form-control" required="true" onkeyup="formataTelefone(this,event);" MaxLength="14" Visible="false"></asp:TextBox>
                        <asp:TextBox ID="txtCelular" runat="server" placeholder="Celular" CssClass="form-control" required="true" onkeyup="formataCelular(this,event);" MaxLength="15" Visible="false"></asp:TextBox>
                        <asp:TextBox ID="txtWhatsapp" runat="server" placeholder="Whatsapp" CssClass="form-control" required="true" onkeyup="formataCelular(this,event);" MaxLength="15" Visible="false"></asp:TextBox>
                    </div>
                </div>
                <br />
                <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar" CssClass="btn btn-info" OnClick="btnAdicionar_Click" />
            </div>
        </div>
    </div>
</asp:Content>

