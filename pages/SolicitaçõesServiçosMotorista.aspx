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
            <div class="serviceBox">
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
            <div class="serviceBox ">
                Nome: 
       
                <asp:Label ID="Label1" runat="server" Text="---"></asp:Label>
                <br />
                Destino:
       
                <asp:Label ID="Label2" runat="server" Text="---"></asp:Label>
                <br />
                Cidade: 
       
                <asp:Label ID="Label3" runat="server" Text="---"></asp:Label>
                <br />
                Numero de Pessoas:
               
                <asp:Label ID="Label4" runat="server" Text="---"></asp:Label>
                <br />
                Data da Viagem:
               
                <asp:Label ID="Label5" runat="server" Text="---"></asp:Label>
                <br />
                Mensagem:
               
                <asp:Label ID="Label6" runat="server" Text="---"></asp:Label>
                <br />
                <br />
                <button type="button" data-toggle="modal" data-target="#meModal " class="btn btn-default">Proposta</button>
                <p>05/17</p>

            </div>

            <div class="serviceBox ">
                Nome: 
       
                <asp:Label ID="Label7" runat="server" Text="---"></asp:Label>
                <br />
                Destino:
       
                <asp:Label ID="Label8" runat="server" Text="---"></asp:Label>
                <br />
                Cidade: 
       
                <asp:Label ID="Label9" runat="server" Text="---"></asp:Label>
                <br />
                Numero de Pessoas:
               
                <asp:Label ID="Label10" runat="server" Text="---"></asp:Label>
                <br />
                Data da Viagem:
               
                <asp:Label ID="Label11" runat="server" Text="---"></asp:Label>
                <br />
                Mensagem:
               
                <asp:Label ID="Label12" runat="server" Text="---"></asp:Label>
                <br />
                <br />
                <button type="button" data-toggle="modal" data-target="#meModal " class="btn btn-default">Proposta</button>
                <p>05/17</p>

            </div>

            <div class="serviceBox ">
                Nome: 
       
                <asp:Label ID="Label13" runat="server" Text="---"></asp:Label>
                <br />
                Destino:
       
                <asp:Label ID="Label14" runat="server" Text="---"></asp:Label>
                <br />
                Cidade: 
       
                <asp:Label ID="Label15" runat="server" Text="---"></asp:Label>
                <br />
                Numero de Pessoas:
               
                <asp:Label ID="Label16" runat="server" Text="---"></asp:Label>
                <br />
                Data da Viagem:
               
                <asp:Label ID="Label17" runat="server" Text="---"></asp:Label>
                <br />
                Mensagem:
               
                <asp:Label ID="Label18" runat="server" Text="---"></asp:Label>
                <br />
                <br />
                <button type="button" data-toggle="modal" data-target="#meModal " class="btn btn-default">Proposta</button>
                <p>05/17</p>

            </div>

            <div class="serviceBox ">
                Nome: 
       
                <asp:Label ID="Label19" runat="server" Text="---"></asp:Label>
                <br />
                Destino:
       
                <asp:Label ID="Label20" runat="server" Text="---"></asp:Label>
                <br />
                Cidade: 
       
                <asp:Label ID="Label21" runat="server" Text="---"></asp:Label>
                <br />
                Numero de Pessoas:
               
                <asp:Label ID="Label22" runat="server" Text="---"></asp:Label>
                <br />
                Data da Viagem:
               
                <asp:Label ID="Label23" runat="server" Text="---"></asp:Label>
                <br />
                Mensagem:
               
                <asp:Label ID="Label24" runat="server" Text="---"></asp:Label>
                <br />
                <br />
                <button type="button" data-toggle="modal" data-target="#meModal " class="btn btn-default">Proposta</button>
                <p>05/17</p>

            </div>
        </div>
    </div>
</asp:Content>

