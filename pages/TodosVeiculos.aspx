    <%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="TodosVeiculos.aspx.cs" Inherits="pages_TodosVeiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Meus Veículos</div>
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
            <div class="serviceBox">
                <div class="title text-right">
                    <span><a href="AlterarVeiculos.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                </div>
                <div class="fotoveiculo"></div>
                
                    Tipo de Veiculo: 
        <asp:Label ID="lblTipo" runat="server" Text="Van"></asp:Label>
                    <br />
                    Modelo:
        <asp:Label ID="lblModelo" runat="server" Text="Sprinter"></asp:Label>
                    <br />
                    Lugares: 
        <asp:Label ID="lblLugares" runat="server" Text="19"></asp:Label>
                    <br />
                    Descrição: 
        <asp:Label ID="lblDescricao" runat="server" Text="---"></asp:Label><br />
                </div>



            <div class="serviceBox">
                <div class="title text-right">
                    <span><a href="AlterarVeiculos.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                </div>
                <div class="fotoveiculo"></div>
                Tipo de Veiculo: 
        <asp:Label ID="Label1" runat="server" Text="Van"></asp:Label>
                <br />
                Modelo:
        <asp:Label ID="Label2" runat="server" Text="Sprinter"></asp:Label>
                <br />
                Lugares: 
        <asp:Label ID="Label3" runat="server" Text="19"></asp:Label>
                <br />
                Descrição: 
        <asp:Label ID="Label4" runat="server" Text="---"></asp:Label>

            </div>


            <div class="serviceBox">
                <div class="title text-right">
                    <span><a href="AlterarVeiculos.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                </div>
                <div class="fotoveiculo"></div>
                Tipo de Veiculo: 
        <asp:Label ID="Label5" runat="server" Text="Van"></asp:Label>
                <br />
                Modelo:
        <asp:Label ID="Label6" runat="server" Text="Sprinter"></asp:Label>
                <br />
                Lugares: 
        <asp:Label ID="Label7" runat="server" Text="19"></asp:Label>
                <br />
                Descrição: 
        <asp:Label ID="Label8" runat="server" Text="---"></asp:Label>

            </div>
            <div class="serviceBox">
                <div class="title text-right">
                    <span><a href="AlterarVeiculos.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                </div>
                <div class="fotoveiculo"></div>
                Tipo de Veiculo: 
        <asp:Label ID="Label9" runat="server" Text="Van"></asp:Label>
                <br />
                Modelo:
        <asp:Label ID="Label10" runat="server" Text="Sprinter"></asp:Label>
                <br />
                Lugares: 
        <asp:Label ID="Label11" runat="server" Text="19"></asp:Label>
                <br />
                Descrição: 
        <asp:Label ID="Label12" runat="server" Text="---"></asp:Label>
            </div>
            <div class="serviceBox">
                <div class="title text-right">
                    <span><a href="AlterarVeiculos.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                </div>
                <div class="fotoveiculo"></div>
                
                    Tipo de Veiculo: 
        <asp:Label ID="Label13" runat="server" Text="Van"></asp:Label>
                    <br />
                    Modelo:
        <asp:Label ID="Label14" runat="server" Text="Sprinter"></asp:Label>
                    <br />
                    Lugares: 
        <asp:Label ID="Label15" runat="server" Text="19"></asp:Label>
                    <br />
                    Descrição: 
        <asp:Label ID="Label16" runat="server" Text="---"></asp:Label><br />
                </div>
            <div class="serviceBox">
                <div class="title text-right">
                    <span><a href="AlterarVeiculos.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                </div>
                <div class="fotoveiculo"></div>
                
                    Tipo de Veiculo: 
        <asp:Label ID="Label17" runat="server" Text="Van"></asp:Label>
                    <br />
                    Modelo:
        <asp:Label ID="Label18" runat="server" Text="Sprinter"></asp:Label>
                    <br />
                    Lugares: 
        <asp:Label ID="Label19" runat="server" Text="19"></asp:Label>
                    <br />
                    Descrição: 
        <asp:Label ID="Label20" runat="server" Text="---"></asp:Label><br />
                </div>
            <div class="serviceBox">
                <div class="title text-right">
                    <span><a href="AlterarVeiculos.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                </div>
                <div class="fotoveiculo"></div>
                
                    Tipo de Veiculo: 
        <asp:Label ID="Label21" runat="server" Text="Van"></asp:Label>
                    <br />
                    Modelo:
        <asp:Label ID="Label22" runat="server" Text="Sprinter"></asp:Label>
                    <br />
                    Lugares: 
        <asp:Label ID="Label23" runat="server" Text="19"></asp:Label>
                    <br />
                    Descrição: 
        <asp:Label ID="Label24" runat="server" Text="---"></asp:Label><br />
                </div>
            <div class="serviceBox">
                <div class="title text-right">
                    <span><a href="AlterarVeiculos.aspx"><span class="glyphicon glyphicon-edit"></span>&nbsp Editar</a></span>
                    <span><a href="#" data-toggle="modal" data-target="#meuModal"><span class="glyphicon glyphicon-remove"></span>&nbsp Excluir</a></span>
                </div>
                <div class="fotoveiculo"></div>
                
                    Tipo de Veiculo: 
        <asp:Label ID="Label25" runat="server" Text="Van"></asp:Label>
                    <br />
                    Modelo:
        <asp:Label ID="Label26" runat="server" Text="Sprinter"></asp:Label>
                    <br />
                    Lugares: 
        <asp:Label ID="Label27" runat="server" Text="19"></asp:Label>
                    <br />
                    Descrição: 
        <asp:Label ID="Label28" runat="server" Text="---"></asp:Label><br />
                </div>
            
        </div>
    </div>
</asp:Content>

