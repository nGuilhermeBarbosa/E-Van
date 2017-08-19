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
            <div class="serviceBox margemDentro">
                <div class="title text-right">
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                    <span><a href="AlterarServiço.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                </div>
                <div class="fotoveiculo"></div>
                Local de Chegada: 
       
                <asp:Label ID="lblTipo" runat="server" Text="---"></asp:Label>
                <br />
                Origem:
       
                <asp:Label ID="lblModelo" runat="server" Text="---"></asp:Label>
                <br />
                Destino: 
       
                <asp:Label ID="lblLugares" runat="server" Text="---"></asp:Label>
                <br />
                <p>05/17</p>
            </div>
            <div class="serviceBox margemDentro">
                <div class="title text-right">
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                    <span><a href="AlterarServiço.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                </div>
                <div class="fotoveiculo"></div>
                Local de Chegada: 
       
                <asp:Label ID="Label1" runat="server" Text="---"></asp:Label>
                <br />
                Origem:
       
                <asp:Label ID="Label2" runat="server" Text="---"></asp:Label>
                <br />
                Destino: 
       
                <asp:Label ID="Label3" runat="server" Text="---"></asp:Label>
                <br />
                <p>05/17</p>
            </div>
            <div class="serviceBox margemDentro">
                <div class="title text-right">
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                    <span><a href="AlterarServiço.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                </div>
                <div class="fotoveiculo"></div>
                Local de Chegada: 
       
                <asp:Label ID="Label4" runat="server" Text="---"></asp:Label>
                <br />
                Origem:
       
                <asp:Label ID="Label5" runat="server" Text="---"></asp:Label>
                <br />
                Destino: 
       
                <asp:Label ID="Label6" runat="server" Text="---"></asp:Label>
                <br />
                <p>05/17</p>
            </div>
            <div class="serviceBox margemDentro">
                <div class="title text-right">
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                    <span><a href="AlterarServiço.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                </div>
                <div class="fotoveiculo"></div>
                Local de Chegada: 
       
                <asp:Label ID="Label7" runat="server" Text="---"></asp:Label>
                <br />
                Origem:
       
                <asp:Label ID="Label8" runat="server" Text="---"></asp:Label>
                <br />
                Destino: 
       
                <asp:Label ID="Label9" runat="server" Text="---"></asp:Label>
                <br />
                <p>05/17</p>
            </div>
        </div>
    </div>
    <div class="getDown"></div>
</asp:Content>

