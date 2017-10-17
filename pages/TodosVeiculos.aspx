<%@ Page Title="Veículos" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="TodosVeiculos.aspx.cs" Inherits="pages_TodosVeiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">
        Meus Veículos
        <span class="glyphicon glyphicon-plus glyphiconBar"><a href="CadastrarVeiculo.aspx">&nbsp Cadastrar Novo Veículo</a></span>
    </div>
    <div id="meuModal" class="modal fade" role="dialog">
        <div class="modal-a">

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
                    <button type="button" class="btn btn-default" data-dismiss="modal">Sim</button>
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                </div>
            </div>

        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            
        </div>
    </div>
</asp:Content>

