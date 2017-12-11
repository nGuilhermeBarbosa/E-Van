<%@ Page Title="Cadastrar Veículo" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="CadastrarVeiculo.aspx.cs" Inherits="pages_CadastrarVeiculo" %>

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

    <div id="fbSuccess" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Cadastro E-Van</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Cadastrado com Sucesso</p>
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
                    <h4 class="modal-title">Cadastro E-Van</h4>
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

    <div class="title text-center">
        <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="TodosVeiculos.aspx">&nbsp;Voltar</a></span>
        Cadastrar Veículo
    </div>
    <br />
    <br />
    <br />
    <div class="signupBox" style="padding-right: 50px;">
        <div class="row">
            <div class="col-lg-12">
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblVeiculo" runat="server" Text="Tipo De Veiculo" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                        <asp:DropDownList ID="ddlVeiculo" runat="server" CssClass="form-control controle dropdown">
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblModelo" runat="server" Text="Modelo" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                        <asp:TextBox ID="txtModelo" runat="server" CssClass="form-control controle"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <asp:HiddenField ID="hdf" runat="server" />
                        <br />
                        <div class="row">
                            <div class="col-lg-3">
                                <asp:Label ID="lblLugar" runat="server" Text="Lugares" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                                <asp:TextBox ID="txtLugar" runat="server" onkeyup="formataInteiro(this, Function);" CssClass="form-control controle" MaxLength="2"></asp:TextBox>
                            </div>
                            <div class="col-lg-3">
                                <asp:Label ID="Label1" runat="server" Text="Ano" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                                <asp:TextBox ID="txtAno" runat="server" onkeyup="formataInteiro(this, Function);" CssClass="form-control controle" MaxLength="4"></asp:TextBox>
                            </div>
                            <div class="col-lg-6">
                                <asp:Label ID="Label2" runat="server" Text="Placa" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>
                                <asp:TextBox ID="txtPlaca" runat="server" onkeyup="formataPlaca(this, Function);" CssClass="form-control controle" MaxLength="8"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <asp:Label ID="lblRecursos" runat="server" Text="Recursos" CssClass="margem"></asp:Label><span style="color:#ff0000;"> *</span>

                        <asp:CheckBox ID="cb1" Value="1" runat="server" Text="Ar-condicionado" CssClass="checkbox box" />
                        <asp:CheckBox ID="cb2" Value="2" runat="server" Text="Wi-fi" CssClass="checkbox box" />
                        <asp:CheckBox ID="cb3" Value="3" runat="server" Text="Televisão" CssClass="checkbox box" />
                        <asp:CheckBox ID="cb4" Value="4" runat="server" Text="Frigobar" CssClass="checkbox box" />
                        <asp:CheckBox ID="cb5" Value="5" runat="server" Text="Rádio" CssClass="checkbox box" />
                        <asp:CheckBox ID="cb6" Value="6" runat="server" Text="Porta Automática" CssClass="checkbox box" />

                        <%--<asp:CheckBoxList ID="cblRecursos" runat="server" CssClass="checkbox box">

                            
                        </asp:CheckBoxList>--%>
                        <br />
                        <asp:Label ID="lblFoto" runat="server" Text="Upload de Fotos: " CssClass="up"></asp:Label>
                        <asp:FileUpload ID="fup" runat="server" CssClass="up" AllowMultiple="true"/>
                        <br />
                        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-default margem" OnClick="btnCadastrar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

