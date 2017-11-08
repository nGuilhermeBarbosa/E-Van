﻿<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Driver.master" AutoEventWireup="true" CodeFile="addCondutor.aspx.cs" Inherits="pages_addCondutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12">
            <div class="title">
                <span class="text-left glyphicon glyphicon-chevron-left leftButton"><a href="Condutores.aspx">&nbsp;Voltar</a></span>
                Adicionar Condutor
            </div>
            <br />
            <br />
            <div class="signupBox" style="margin-top: 20px;">
                Nome:&nbsp;<asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" CssClass="form-control" required="true" MaxLength="50"></asp:TextBox><br />
                CPF:&nbsp;<asp:TextBox ID="txtCPF" runat="server" placeholder="CPF" CssClass="form-control" required="true" onkeyup="formataCPF(this,event);" MaxLength="14"></asp:TextBox><br />
                <div class="row">
                    <div class="col-lg-3">Tipo de Contato:&nbsp;
                        <asp:DropDownList ID="ddl" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddl_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Value="0">Telefone Fixo</asp:ListItem>
                            <asp:ListItem Value="1">Celular</asp:ListItem>
                            <asp:ListItem Value="2">Whatsapp</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-9">
                        Contato:&nbsp;
                        <asp:TextBox ID="txtTelefone" runat="server" placeholder="Telefone" CssClass="form-control" required="true" onkeyup="formataTelefone(this,event);" MaxLength="14"></asp:TextBox>
                        <asp:TextBox ID="txtCelular" runat="server" placeholder="Celular" CssClass="form-control" required="true" onkeyup="formataCelular(this,event);" MaxLength="15" Visible="false"></asp:TextBox>
                        <asp:TextBox ID="txtWhatsapp" runat="server" placeholder="Whatsapp" CssClass="form-control" required="true" onkeyup="formataCelular(this,event);" MaxLength="15" Visible="false"></asp:TextBox>
                        <br />
                    </div>
                </div>
                <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar" CssClass="btn btn-info" OnClick="btnAdicionar_Click" />
            </div>
        </div>
    </div>
</asp:Content>

