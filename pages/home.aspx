<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="pages_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-9">
            <div class="title text-center">Principais Serviços</div>
            <div class="row">
                <div class="col-lg-3">
                    <div class="serviceBox">
                        <div class="padding">
                            <h1>Claudemir</h1>
                            <hr />
                            <b>Local de chegada</b>
                            <p>Praia Grande</p>
                            <b>Origem</b>
                            <p>Guaratinguetá</p>
                            <b>Destino</b>
                            <p>Ubatuba</p>
                        </div>
                        <p class="text-center">9/5/2017</p>
                    </div>
                    
                </div>
                <div class="col-lg-3">
                    <div class="serviceBox Free">
                        <div class="padding">
                            <h1>Claudemir</h1>
                            <hr />
                            <b>Local de chegada</b>
                            <p>Praia Grande</p>
                            <b>Origem</b>
                            <p>Guaratinguetá</p>
                            <b>Destino</b>
                            <p>Ubatuba</p>
                        </div>
                        <p class="text-center">9/5/2017</p>
                    </div>
                </div>
                <div class="col-lg-4">
                    
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="title text-center">Motoristas mais bem avaliados</div>
            <div class="row">
                <div class="col-lg-12">
                    <div class="serviceBox userAvaliate padding">
                        Nome: Claudemir<br />
                        Cidade: Guaratinguetá<br />
                        Número de avaliadores: 5<br />
                        [AVALIAÇÃO]
                    </div>
                    <div class="serviceBox userAvaliate padding">
                        "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..."
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Ver todas as avaliações" CssClass="btn btn-default buttonShowAll" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

