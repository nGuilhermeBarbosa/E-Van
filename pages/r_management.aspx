﻿<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Client.master" AutoEventWireup="true" CodeFile="r_management.aspx.cs" Inherits="pages_r_management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row page">
        <div class="col-lg-12">
            <div class="title text-center">Gerencimento de Solicitações</div>
            <div class="col-lg-2">
                <div class="serviceBox">
                    <div class="title text-right">
                        <span class="glyphicon glyphicon-edit">Editar</span>
                        <span class="glyphicon glyphicon-remove">Excluir</span>
                    </div>
                    <div class="padding">
                        Nome: Eduardo<br />
                        Cidade: Aparecida<br />
                        Destino: Rock in Rio<br />
                        Mensagem: Boa tarde, gostaria de fechar uma van para o Rock in Rio!
                    </div>
                    <p class="text-center">Data da viagem: 05/10/2017</p>
                </div>
            </div>

            <div class="col-lg-2">
                        <asp:Button ID="Button1" runat="server" Text="Adicionar" CssClass="btn btn-success" />
            </div>

        </div>
    </div>
</asp:Content>
