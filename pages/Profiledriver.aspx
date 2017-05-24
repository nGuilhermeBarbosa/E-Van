<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="Profiledriver.aspx.cs" Inherits="pages_Profiledriver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="title text-center">Perfil Motorista</div>
    <div class="row">
        <div class="col-lg-12">
            <div class="serviceBox">
                <div class="title">
                    <span class="glyphicon glyphicon-remove">Desativar</span>
                    <span class="glyphicon glyphicon-bell">Notificar</span>
                </div>
                <div class="fotoveiculo"></div>
                Nome do Motorista A: 
        <asp:Label ID="lblTipo" runat="server" Text=" João Carlos"></asp:Label>
                <br />
                CNH:
        <asp:Label ID="lblModelo" runat="server" Text="452366"></asp:Label>
                <br />
                <br />
                <br />

    



            </div>


            <div class="serviceBox">
                <div class="title">
                    <span class="glyphicon glyphicon-remove">Desativar</span>
                    <span class="glyphicon glyphicon-bell">Notificar</span>
                </div>
                <div class="fotoveiculo"></div>
                Nome do Motorista B: 
        <asp:Label ID="Label1" runat="server" Text=" Lucas Castro"></asp:Label>
                <br />
                CNH:
        <asp:Label ID="Label2" runat="server" Text=" 98562"></asp:Label>
                <br />
                <br />
                <br />

     
            </div>


            <div class="serviceBox">
                <div class="title">
                    <span class="glyphicon glyphicon-remove">Desativar</span>
                    <span class="glyphicon glyphicon-bell">Notificar</span>
                </div>
                <div class="fotoveiculo"></div>
                Nome do Motorista C: 
        <asp:Label ID="Label3" runat="server" Text=" Yuri Melo"></asp:Label>
                <br />
                CNH:
        <asp:Label ID="Label4" runat="server" Text=" 857452"></asp:Label>
                <br />
                <br />
                <br />

             
            </div>

            <div class="serviceBox">
                <div class="title">
                    <span class="glyphicon glyphicon-remove">Desativar</span>
                    <span class="glyphicon glyphicon-bell">Notificar</span>
                </div>
                <div class="fotoveiculo"></div>
                Nome do Motorista D: 
        <asp:Label ID="Label5" runat="server" Text=" Manoel D."></asp:Label>
                <br />
                CNH:
        <asp:Label ID="Label6" runat="server" Text=" 586955"></asp:Label>
                <br />
                <br />
                <br />

            
            </div>
        </div>
    </div>
    <br />
    <div class="getDown"></div>
</asp:Content>

