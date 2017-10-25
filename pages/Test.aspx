<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Public.master" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="pages_Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="fbSuccess" class="modal fade" role="dialog">
                <div class="modal-dialog">

                    <div class="modal-content">
                        <div class="modal-header">
                            <div class="close" data-dismiss="modal">&times;</div>
                            <h4 class="modal-title">Teste de Modal</h4>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <p class="glyphicon glyphicon-ok" style="font-size:90px;"></p>
                                    Ação realizada com Sucesso
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
    <div class="row">
        <div class="col-lg-12">
            <button type="button" class="btn btn-success" data-toggle="#fbSuccess">Testar Modal OK</button>
        </div>
    </div>
    
</asp:Content>

