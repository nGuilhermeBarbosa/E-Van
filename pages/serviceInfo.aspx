<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="serviceInfo.aspx.cs" Inherits="pages_serviceInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-4">
            <div class="title text-center">Serviço</div>
            <div class="serviceBox info noMargin">
                <div class="padding">
                    Local: Praia Grande
                <br />
                    Origem: Guaratinguetá
                <br />
                    Destino: Ubatuba
                <br />
                </div>
                <p>Data da viagem: 06/07</p>
            </div>
            <br />

            <div class="title text-center">Veículo</div>
            <div class="serviceBox info noMargin">
                <div class="padding">
                    001<br />
                    Tipo: Van<br />
                    Complementos: Wi-fi<br />
                    Lugares: 15
                <div class="row">
                    <div class="col-lg-6">Foto ABNT</div>
                    <div class="col-lg-6">Foto ARTESP</div>
                </div>
                </div>
                <p>Lugares Disponíveis: 5/15</p>
            </div>
            <br />
        </div>
        <div class="col-lg-4">
            <div class="title text-center">Contatos</div>
            <div class="serviceBox info noMargin padding">
                Telefone: (12)3152-6361<br />
                Celular: (12)98162-6478<br />
                Whatsapp: (12)98162-6478<br />
                E-Mail: demirvans@outlook.com<br />
            </div>
            <br />

            <div class="title text-center">Motorista</div>
            <div class="serviceBox info noMargin padding">
                Nome: Claudemir da Silva<br />
                CNH: 358185016<br />
            </div>
            <br />

            <div class="serviceBox padding noMargin Free">
                Você tem interesse nesse serviço? <br />
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Sim" />
            </div>
            <br />
        </div>
        <div class="col-lg-4">
            <div class="title text-center">Fotos do Veículo</div>
        </div>
    </div>
</asp:Content>

