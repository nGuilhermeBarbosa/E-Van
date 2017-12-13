<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="CompletaCadastro.aspx.cs" Inherits="pages_CompletaCadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function openModalS() {
            $('#fbSuccess').modal('show');
        }
        function openModalE() {
            $('#fbError').modal('show');
        }
        function openModalF() {
            $('#fbFile').modal('show');
        }
        function openModalSl() {
            $('#fbSelect').modal('show');
        }
        function openModalMS() {
            $('#fbMS').modal('show');
        }
        function openModalEI() {
            $('#fbEI').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="../js/AddTelefone.js"></script>

    <div id="fbSuccess" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Completar Cadastro</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Cadastro Completado com Sucesso</p>
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
                    <h4 class="modal-title">Completar Cadastro</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-remove col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Ocorreu um erro, por favor verifique os campos e tente novamente</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="fbFile" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Completar Cadastro</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-alert col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Erro, o arquivo a ser enviado já existente no sistema, verifique o nome do arquivo e tente novamente</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="fbSelect" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Completar Cadastro</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-alert col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Por favor selecione um arquivo para enviar</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="fbMS" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Completar Cadastro</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-alert col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Erro, tamanho máximo exercido, por favor selecione um arquivo com tamanho inferior a 500KB</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div id="fbEI" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Completar Cadastro</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-alert col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Erro, Extensão inválida, por favor selecione um arquivo nos formatos .png, .jpg ou .gif</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="title text-center">Completar Cadastro</div>
    <asp:Panel ID="pBefore" runat="server">
        <br />
        <br />
        <br />

        <div class="signupBox">
            Selecione o tipo de conta
            <div class="row">
                <div class="col-lg-6">
                    <asp:RadioButton ID="cbFree" runat="server" value="Free" Text=" Gratuita" CssClass="checkbox-inline" AutoPostBack="true" Checked="true" OnCheckedChanged="cbFree_CheckedChanged" />
                </div>
                <div class="col-lg-6">
                    <asp:RadioButton ID="cbPremium" runat="server" value="Premium" Text=" Premium" CssClass="checkbox-inline" AutoPostBack="true" OnCheckedChanged="cbPremium_CheckedChanged"/>
                </div>
            </div>
            <asp:Panel ID="panelFree" runat="server" Visible="true">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="serviceBox info padding Free" style="width: 96%; padding: 10px; text-align: center;">
                            A conta gratuita oferece total acesso ao sistema, porém o usuário poderá realizar apenas 5 (cinco) publicações mensalmente.
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="panelPremium" runat="server" Visible="false">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="serviceBox info padding Free" style="width: 96%; padding: 10px; text-align: center;">
                            A conta premium oferece total acesso ao sistema com publicações ilimitadas.
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6">
                        <div class="serviceBox info padding Free" style="width: 96%; height: 50px; padding: 10px; text-align: center;">
                            <asp:RadioButton ID="rbMensal" runat="server" AutoPostBack="true" CssClass="checkbox-inline" OnCheckedChanged="rbMensal_CheckedChanged"/>
                            Plano mensal de R$ 14,99.
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="serviceBox info padding Free" style="width: 96%; height: 50px; padding: 10px; text-align: center;">
                            <asp:RadioButton ID="rbAnual" runat="server" AutoPostBack="true" CssClas="checkbox-inline" OnCheckedChanged="rbAnual_CheckedChanged"/>
                            Plano anual de R$ 99,99.
                        </div>
                    </div>
                </div>
            </asp:Panel><br />
            <div class="row">
                <div class="col-lg-3">
                    <asp:HiddenField ID="hdf" runat="server" />
                    <asp:Label ID="Telefone" runat="server" Text="Contato" CssClass="margem" required="true" onkeyup="formataTelefone(this,event);"></asp:Label>
                    <asp:DropDownList ID="ddl" runat="server" CssClass="form-control controle" OnSelectedIndexChanged="ddl_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                </div>
                <div class="col-lg-5">
                    <br />
                    <asp:TextBox ID="txtWhatsapp" runat="server" CssClass="form-control" onkeyup="formataCelular(this,event);" MaxLength="15" Visible="false" placeholder="Whatsapp"></asp:TextBox>
                    <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control" onkeyup="formataCelular(this,event);" MaxLength="15" Visible="false" placeholder="Celular"></asp:TextBox>
                    <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control" onkeyup="formataTelefone(this,event);" MaxLength="14" Visible="false" placeholder="Telefone"></asp:TextBox>
                    <asp:TextBox ID="txtEmailAlt" runat="server" CssClass="form-control" TextMode="Email" MaxLength="100" Visible="false" placeholder="Email Alternativo"></asp:TextBox>
                    <asp:Panel ID="pnl" runat="server"></asp:Panel>
                </div>
                <%--<div class="col-lg-3">
                    <asp:Button ID="btnAdicionar" runat="server" Text="+" CssClass="btn btn-link" Style="font-size: 22px; margin-top: 0.7em" />
                </div>--%>

            </div>
            <br />
            <br />
            <asp:FileUpload ID="fup" runat="server" AllowMultiple="true" />
            <br />
            <br />
            
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-info margem" OnClick="btnEnviar_Click" />
        </div>
    </asp:Panel>
    <asp:Panel ID="pAfter" runat="server" Visible="false">
        <br />
        <br />
        <br />
        <div class="signupBox">
            <div class="text-center">Informações enviadas com sucesso</div>
            <button type="button" onclick="window.location.replace('homemotorista.aspx')" class="btn btn-info center-block">Voltar para a Home Page</button>
        </div>
    </asp:Panel>
</asp:Content>

