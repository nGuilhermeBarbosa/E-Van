<%@ Page Title="Cadastro de Serviço" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="CadastroServiçoMotorista.aspx.cs" Inherits="pages_CadastroServiço" %>

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
                    <h4 class="modal-title">Cadastro de Serviço</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-ok col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Serviço Cadastrado com Sucesso</p>
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
                    <h4 class="modal-title">Cadastro de Serviço</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-remove col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Erro ao cadastrar o serviço, por favor verifique os campos acima e tente novamente!</p>
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
                <asp:HiddenField ID="hdf" runat="server" />
                <br />
                <asp:Label ID="lblOrigem" runat="server" Text="Origem" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtOrigem" runat="server" CssClass="form-control controle" required="true"></asp:TextBox>
                <br />
                <asp:Label ID="lblDestino" runat="server" Text="Destino" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control controle" required="true"></asp:TextBox>
                <br />
                <br />
                <div class="row">
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataInicio" runat="server" Text="Data Partida" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtDataInicio" runat="server" TextMode="Date" CssClass="form-control controle" required="true"></asp:TextBox>
                        <br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="lblDataFim" runat="server" Text="Data Retorno" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtDataFim" runat="server" TextMode="Date" CssClass="form-control controle" required="true"></asp:TextBox>
                        <br />
                    </div>
                    <br />
                    <div class="col-lg-6">
                        <asp:Label ID="Label1" runat="server" Text="Hora Partida" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtHoraPartida" runat="server" type="Time" CssClass="form-control controle" required="true"></asp:TextBox>
                        <br />
                    </div>
                    <div class="col-lg-6">
                        <asp:Label ID="Label2" runat="server" Text="Hora Retorno" CssClass="margem"></asp:Label>
                        <asp:TextBox ID="txtHoraRetorno" runat="server" type="Time" CssClass="form-control controle" required="true"></asp:TextBox>
                        <br />
                    </div>
                </div>
                <br />
                <asp:Panel ID="pnl" runat="server">
                    <asp:Label ID="lblCondutores" runat="server" Text="Condutores" CssClass="margem"></asp:Label>
                    <asp:DropDownList ID="ddlCondutor" runat="server" CssClass="form-control controle"></asp:DropDownList>
                </asp:Panel>
                <br />
                <asp:Label ID="lblLugares" runat="server" Text="Lugares Disponiveis" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtLugares" runat="server" CssClass="form-control controle" required="true"></asp:TextBox>
                <br />
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição" CssClass="margem"></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" CssClass="form-control controle" required="true"></asp:TextBox>
                <br />
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-info margem" OnClick="btnCadastrar_Click" />
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>

