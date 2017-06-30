<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="allAdmin.aspx.cs" Inherits="pages_allAdmin" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="title text-center">
            Todos Administradores
            <span class="glyphicon glyphicon-plus glyphiconBar">&nbsp;<a href="addAdmin.aspx">Adicionar Administrador</a></span>
        </div>

        <div class="col-lg-12">
            <div class="serviceBox ">
                <div class="title text-right">
                    <span class="glyphicon glyphicon-remove">Excluir</span>
                </div>
                <div class="padding">
                    Administrador A<br />
                    Cidade: Lorena<br />
                    Telefone: 3152-6361<br />
                    CPF: 937.203.987-40<br />
                    E-mail: joao@outlook.com
                </div>
            </div>
            <div class="col-lg-12">
                <br />
            </div>
        </div>       
    </div>
    <br />
    <div class="getDown"></div>
</asp:Content>

