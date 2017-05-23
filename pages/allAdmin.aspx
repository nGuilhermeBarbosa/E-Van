<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Admin.master" AutoEventWireup="true" CodeFile="allAdmin.aspx.cs" Inherits="pages_allAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">    
    <div class="row">
        <div class="title text-center">Todos Administradores</div>
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
                        E-mail: demirvans@outlook.com
                    </div>
                </div>
            <div class="col-lg-12">
                <br />
                <asp:Button ID="btnAddAmin" runat="server" Text="Adicionar Administrador" CssClass="btn btn-success" />
            </div>
        </div>
    </div>
</asp:Content>

