<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="TodosServicosMotorista.aspx.cs" Inherits="pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">
        Meus Serviços
        <span class="glyphicon glyphicon-plus glyphiconBar"><a href="CadastroServiçoMotorista.aspx">&nbsp Cadastrar Novo serviço</a></span>
    </div>
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
                            Tem certeza que deseja excluir ?
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnExcluir" class="btn btn-default" runat="server" Text="Sim" onclick="btnExcluir_Click"/>
                    <asp:Button ID="btnCancelar" class="btn btn-default" runat="server" Text="Cancelar" />
                </div>
            </div>

        </div>
    </div>
    <script type="text/javascript">
            function openModal() {
                $('#meuModal').modal('show');
            }
        </script>
        <div class="col-lg-9" style="float: left;">
            <asp:Literal ID="Literal1" runat="server">
            </asp:Literal>
        </div>
        <div class="col-lg-3" style="margin-top:10px;">
            <b class="glyphicon glyphicon-edit"> Editar</b><br />
            <asp:DropDownList ID="ddlEdit" runat="server" CssClass="form-horizontal" OnSelectedIndexChanged="ddlEdit_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br /><br />
            <b class="glyphicon glyphicon-trash"> Excluir</b><br />
            <asp:DropDownList ID="ddlDelete" runat="server" CssClass="form-horizontal" OnSelectedIndexChanged="ddlDelete_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>

</asp:Content>

