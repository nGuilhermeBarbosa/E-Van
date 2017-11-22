<%@ Page Title="Serviços" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="TodosServicosMotorista.aspx.cs" Inherits="pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="meuModal" class="modal fade" role="dialog">
        <div class="modal-a">
            <asp:HiddenField ID="hdf" runat="server" />
            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">

                            <p id="par"></p>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <a href="#" class="btn btn-default" onclick="exc();">Simm</a>
                    <asp:Button ID="btnExcluir" class="btn btn-default" runat="server" Text="Sim" OnClick="btnExcluir_Click" />
                    <asp:Button ID="btnCancelar" class="btn btn-default" runat="server" Text="Cancelar" />
                </div>
            </div>

        </div>
    </div>

    <div id="modalLimite" class="modal fade" role="dialog">
        <div class="modal-dialog" id="video" style="float: unset; width: 400px;">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Atenção</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <p class="glyphicon glyphicon-alert col-xs-12 text-center" style="font-size: 90px;"></p>
                            <br />
                            <p class="text-center">Lamentamos informar que você atingiu seu limite mensal de divulgação de serviço, aguarde a virada do mês para divulgar novamente.</p>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <script type="text/javascript">
        function openModal() {
            $('#meuModal').modal('show');
        }
        function openModalLimite() {
            $('#modalLimite').modal('show');
        }
    </script>
    <div class="row">
        <%--<asp:Label ID="Label1" runat="server" Text="can you see this?" style="visibility:hidden"></asp:Label>--%>
        <div class="title text-center col-lg-12">
            Meus Serviços
        <asp:LinkButton id="csm" runat="server" CssClass="glyphicon glyphicon-plus glyphiconBar" OnClick="csm_Click" Text=" Cadastrar novo serviço" style="float: right; margin: 0 5px 5px 5px; cursor: pointer; color: inherit !important; text-decoration: none !important;"/>
            <asp:Label ID="fbse" runat="server" Text="Nada de viajar no tempo" Visible="false" style="background:#ff6a00; height:38px; margin-top:-8px; line-height:20px; padding:10px;"></asp:Label>
            <asp:Label ID="fbLimite" runat="server" Text="" Visible="false" style="background:#ff6a00; height:38px; margin-top:-8px; line-height:20px; padding:10px; cursor:default;"></asp:Label>
            <asp:Label ID="fbUnlimited" runat="server" Text="Publicações Ilimitadas" Visible="true" style="background:#00e888; height:38px; margin-top:-8px; line-height:20px; padding:10px; cursor:default;"></asp:Label>
        </div>
        <div class="col-lg-12">
            <asp:Literal ID="Literal1" runat="server">
            </asp:Literal>
        </div>
       <!-- <div class="col-lg-3">
            <b class="glyphicon glyphicon-edit">Editar</b><br />
            <asp:DropDownList ID="ddlEdit" runat="server" CssClass="form-horizontal" OnSelectedIndexChanged="ddlEdit_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br />
            <br />
            <b class="glyphicon glyphicon-trash">Excluir</b><br />
            <asp:DropDownList ID="ddlDelete" runat="server" CssClass="form-horizontal" OnSelectedIndexChanged="ddlDelete_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div> -->
    </div>

    <script src="jsExcluir.js">
       


    </script>
</asp:Content>

