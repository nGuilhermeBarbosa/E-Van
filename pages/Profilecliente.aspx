<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="Profilecliente.aspx.cs" Inherits="pages_Profilecliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Perfil Cliente</div>
    <div class="row">
        <div class="col-lg-12">
            <div class="serviceBox">
                <div class="title text-right">
                    <span class="glyphicon glyphicon-remove">Desativar</span>
                    <span class="glyphicon glyphicon-bell">Notificar</span>
                </div>
                <div class="fotoveiculo"></div>
                Nome do Cliente A: 
        <asp:Label ID="lblTipo" runat="server" Text=" Guilherme"></asp:Label>
                <br />
                CPF:
        <asp:Label ID="lblModelo" runat="server" Text=" 310.262.398-00"></asp:Label>
                <br />
                <br />
                <br />

        

            </div>


            <div class="serviceBox">
                <div class="title text-right">
                   <span class="glyphicon glyphicon-remove">Desativar</span>
                    <span class="glyphicon glyphicon-bell">Notificar</span>
                </div>
                <div class="fotoveiculo"></div>
                Nome do Cliente B: 
        <asp:Label ID="Label1" runat="server" Text=" Thiago J."></asp:Label>
                <br />
                CNH:
        <asp:Label ID="Label2" runat="server" Text=" 265.698.958-63"></asp:Label>
                <br />
                <br />
                <br />

             
            </div>


            <div class="serviceBox">
                <div class="title text-right">
                   <span class="glyphicon glyphicon-remove">Desativar</span>
                    <span class="glyphicon glyphicon-bell">Notificar</span>
                </div>
                <div class="fotoveiculo"></div>
                Nome do Cliente C: 
        <asp:Label ID="Label3" runat="server" Text=" Matheus lima"></asp:Label>
                <br />
                CPF:
        <asp:Label ID="Label4" runat="server" Text=" 785.698.598-21"></asp:Label>
                <br />
                <br />
                <br />


        
            </div>

            <div class="serviceBox">
                <div class="title text-right">
                  <span class="glyphicon glyphicon-remove">Desativar</span>
                    <span class="glyphicon glyphicon-bell">Notificar</span>
                </div>
                <div class="fotoveiculo"></div>
                Nome do Cliente D: 
        <asp:Label ID="Label5" runat="server" Text=" Luiz Castro"></asp:Label>
                <br />
                CPF:
        <asp:Label ID="Label6" runat="server" Text=" 659.369.987-52"></asp:Label>
                <br />
                <br />
                <br />



            </div>
        </div>
    </div>
    <br /><div class="getDown"></div>
</asp:Content>

