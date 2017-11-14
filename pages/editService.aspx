<%@ Page Title="Editar Serviço" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="editService.aspx.cs" Inherits="pages_CadastroServiço" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
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
                    <h4 class="modal-title">Atualizar Serviço</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Serviço atualizado com sucesso</p>
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
                    <h4 class="modal-title">Atualizar Serviço</h4>
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
    <div class="title text-center">Cadastro De Serviço</div>
    <br />
    <br />
    <br />
    <div class="signupBox">
        <div class="row">
            <div class="col-lg-11">
                <asp:Label ID="Label1" runat="server" Text="can you see this?" style="visibility:hidden"></asp:Label>
                <br />
                <asp:Label ID="lblOrigem" runat="server" Text="Origem" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtOrigem" runat="server" CssClass="form-control controle"></asp:TextBox>
                <br />
                <asp:Label ID="lblDestino" runat="server" Text="Destino" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control controle"></asp:TextBox>
                <br />               
                <br />
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataInicio" runat="server" Text="Data Inicio" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtDataInicio" runat="server" CssClass="form-control controle"></asp:TextBox>
                        <br />
                    </div>  
                    <div class ="col-lg-6">
                        <asp:Label ID="lblDataFim" runat="server" Text="Data de Fim" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtDataFim" runat="server" CssClass="form-control controle"></asp:TextBox>
                        <br />
                    </div>
                </div>
                <br />
                <asp:Label ID="lblCondutores" runat="server" Text="Condutores" CssClass="margem"></asp:Label>
                <asp:DropDownList ID="ddlCondutor" runat="server" CssClass="form-control controle" AutoPostBack="True"></asp:DropDownList>
                <br />
                <asp:Label ID="lblLugares" runat="server" Text="Lugares Disponiveis" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtLugares" runat="server" CssClass="form-control controle"></asp:TextBox>
                <br />
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" CssClass="form-control controle"></asp:TextBox>
                <br />
                <asp:Button ID="btnUpdate" runat="server" Text="Atualizar" CssClass="btn btn-info margem" OnClick="btnUpdate_Click" />
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>

