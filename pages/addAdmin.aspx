<%@ Page Title="Adicionar Administrador" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="addAdmin.aspx.cs" Inherits="pages_addAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        function openModalS() {
            $('#fbSuccess').modal('show');
        }
        function openModalE() {
            $('#fbError').modal('show');
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
                            <p class="text-center">As senhas estão diferentes!</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="title">
        <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="allAdmin.aspx">&nbsp;Voltar</a></span>
        Adicionar Administrador
    </div>
    <br />
    <br />
    <br />
    <div class="signupBox">
        <div class="row">
            <div class="col-lg-12">
                <br />
                <div class="row">
                    <div class="col-lg-6">
                        Nome Completo<span style="color: #ff0000;"> *</span>
                        <asp:TextBox ID="txtNomeA" runat="server" CssClass="form-control" required="required"></asp:TextBox><br />
                    </div>
                    <div class="col-lg-6">
                        Sexo<span style="color: #ff0000;"> *</span>
                        <asp:DropDownList ID="ddlSexoA" runat="server" CssClass="form-control">
                            <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                            <asp:ListItem Value="F">Feminino</asp:ListItem>
                        </asp:DropDownList><br />
                    </div>
                    <div class="col-lg-12">
                        E-Mail<span style="color: #ff0000;"> *</span>
                        <asp:TextBox ID="txtEmailA" runat="server" CssClass="form-control" TextMode="Email" required="required"></asp:TextBox><br />
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-6">
                        Senha<span style="color: #ff0000;"> *</span>
                        <asp:TextBox ID="txtSenhaA" runat="server" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                        <asp:Label ID="lblCS" runat="server" Text="---" Visible="false" CssClass="alert-danger"></asp:Label><br />
                    </div>
                    <div class="col-lg-6">
                        Digite a senha novamente<span style="color: #ff0000;"> *</span>
                        <asp:TextBox ID="txtConfirmarSenha" runat="server" CssClass="form-control" TextMode="Password" required="required"></asp:TextBox><br />
                    </div>
                </div>
                Data de Nascimento<span style="color: #ff0000;"> *</span>
                <asp:TextBox ID="txtDataNasc" runat="server" type="date" CssClass="form-control" required="required"></asp:TextBox><br />

                <div class="row">
                    <div class="col-lg-6">
                        Estado<span style="color: #ff0000;"> *</span>
                        <asp:DropDownList ID="ddlEstadoA" runat="server" CssClass="form-control dropdown">
                            <asp:ListItem Selected="True">SP</asp:ListItem>
                        </asp:DropDownList><br />
                    </div>
                    <div class="col-lg-6">
                        Cidade<span style="color: #ff0000;"> *</span>
                        <asp:DropDownList ID="ddlCidadeA" runat="server" CssClass="form-control dropdown">
                            <asp:ListItem>Aparecida</asp:ListItem>
                            <asp:ListItem Selected="True">Guaratinguet&#225;</asp:ListItem>
                            <asp:ListItem>Lorena</asp:ListItem>
                            <asp:ListItem>S&#227;o Jos&#233; dos Campos</asp:ListItem>
                            <asp:ListItem>Taubat&#233;</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="center">
                        <asp:Button ID="Button2" runat="server" Text="Cadastrar" CssClass="btn btn-success" OnClick="btnConfirmaCadastro_Click" />
                        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

