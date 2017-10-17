<%@ Page Title="Serviços" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Servicos.aspx.cs" Inherits="pages_Servicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="modalNext" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <div class="modal-content">
                <div class="modal-header">
                    <div class="close" data-dismiss="modal">&times;</div>
                    <h4 class="modal-title">Um momento</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            Lamentamos informar que para prosseguir deve estar cadastrado no sistema
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <div class="title">Serviços</div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </div>

</asp:Content>

