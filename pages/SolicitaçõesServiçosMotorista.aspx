<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="SolicitaçõesServiçosMotorista.aspx.cs" Inherits="pages_SolicitaçõesServiçosMotorista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Solicitações De Serviços</div>
    <div id="meModal" class="modal fade">
        <div class="modal-a">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Sua Proposta</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <asp:TextBox ID="txtProposta" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Enviar</button>
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                </div>
            </div>

        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="serviceBox margemDentro">
                Nome: 
        <asp:Label ID="lblTipo" runat="server" Text="---"></asp:Label>
                <br />
                Destino:
        <asp:Label ID="lblModelo" runat="server" Text="---"></asp:Label>
                <br />
                Cidade: 
        <asp:Label ID="lblLugares" runat="server" Text="---"></asp:Label>
                <br />
                Numero de Pessoas:
                <asp:Label ID="lblNumero" runat="server" Text="---"></asp:Label>
                <br />
                Data da Viagem:
                <asp:Label ID="lblViagem" runat="server" Text="---"></asp:Label>
                <br />
                Mensagem:
                <asp:Label ID="lblMensagem" runat="server" Text="---"></asp:Label>
                <br />
                <br />
                <button type="button" data-toggle="modal" data-target="#meModal " class="btn btn-default">Proposta</button>
                <p>05/17</p>

            </div>
        </div>
    </div>
</asp:Content>

