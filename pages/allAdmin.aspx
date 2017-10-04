<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="allAdmin.aspx.cs" Inherits="pages_allAdmin" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="title text-center">
            Todos Administradores
            <span class="glyphicon glyphicon-plus glyphiconBar">&nbsp;<a href="addAdmin.aspx">Adicionar Administrador</a></span>
        </div>

        <!-- Modal -->
        <div id="ModalDelete" class="modal fade" role="dialog">
            <div class="modal-dialog mdleft">

                <div class="modal-content">
                    <div class="modal-header">
                        <div class="close" data-dismiss="modal">&times;</div>
                        <h4 class="modal-title">Atenção</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-lg-12">
                                <p>Tem deseja se deseja excluir este usuário?</p>
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
                $('#ModalDelete').modal('show');
            }
        </script>

        <div class="col-lg-9" style="float: left;">
            <asp:Literal ID="Literal1" runat="server">
            </asp:Literal>
        </div>
        <div class="col-lg-3" style="float: right;">
            <p class="glyphicon glyphicon-trash"></p>
            <asp:DropDownList ID="ddlAdmin" runat="server" OnSelectedIndexChanged="ddlAmdmin_SelectedIndexChanged" AutoPostBack="true" CssClass="form-inline" Style="margin-top: 10px;"></asp:DropDownList><br />
            <p class="glyphicon glyphicon-edit"></p>
            <asp:DropDownList ID="DropDownListEdit" runat="server" OnSelectedIndexChanged="DropDownListEdit_SelectedIndexChanged" AutoPostBack="true" CssClass="form-inline" Style="margin-top: 10px;"></asp:DropDownList>
        </div>
        <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>


    </div>
</asp:Content>

